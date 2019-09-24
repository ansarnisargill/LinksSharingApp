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
    public class CashCheckoutModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public Link link { get; set; }
        public void OnGet(int id)
        {
            this.link = _context.Links.First(x => x.ID == id);
        }
        public CashCheckoutModel(LinkAppContext context)
        {
            _context = context;
        }
    }
}