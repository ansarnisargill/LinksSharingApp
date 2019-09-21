using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayPal.Core;
using PayPal.v1.Payments;

namespace LinkShareApp.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public Code Code { get; set; } = new Code();
        public void OnGet(int id)
        {
            var Link = _context.Links.First(x => x.ID == id);

            var TillDate = DateTime.Now.AddDays(1);
            var code = RandomString(10);
            while (_context.Codes.Any(x => x.CodeTerm == code))
            {
                code = RandomString(10);
            }
            var NewCode = new Code()
            {
                Amount = Link.PricePerDay,
                LinkId = Link.ID,
                CodeTerm = code,
                ValidTill = TillDate
            };
            _context.Codes.Add(NewCode);
            _context.SaveChanges();
            this.Code = NewCode;
        }
        public CheckoutModel(LinkAppContext context)
        {
            _context = context;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public async void GetPayment(string money,string intent)
        {
            var environment = new SandboxEnvironment("AdV4d6nLHabWLyemrw4BKdO9LjcnioNIOgoz7vD611ObbDUL0kJQfzrdhXEBwnH8QmV-7XZjvjRWn0kg", "EPKoPC_haZMTq5uM9WXuzoxUVdgzVqHyD5avCyVC1NCIUJeVaNNUZMnzduYIqrdw-carG9LBAizFGMyK");
            var client = new PayPalHttpClient(environment);

            var payment = new Payment()
            {
                Intent = intent,
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = money,
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
        }
    }
}