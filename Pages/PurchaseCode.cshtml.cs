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
    public class PurchaseCodeModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public Link Link { get; set; } = new Link();
        public void OnGet(int Linkid)
        {
            Link = _context.Links.First(x => x.ID == Linkid);
        }
        public PurchaseCodeModel(LinkAppContext context)
        {
            _context = context;
        }
    }
}