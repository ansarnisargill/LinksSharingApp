using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkShareApp.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public Code Code { get; set; } = new Code();
        public void OnGet(int id,string date)
        {
            var Link = _context.Links.First(x => x.ID == id);
            var TillDate = DateTime.Parse(date);
            var code = RandomString(10);
            while (_context.Codes.Any(x => x.CodeTerm == code))
            {
                code= RandomString(10);
            }
            var hours = Convert.ToDecimal((TillDate - DateTime.Now).Minutes)/60M;
            var NewCode = new Code()
            {
                Amount = Link.PricePerHour * hours,
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
    }
}