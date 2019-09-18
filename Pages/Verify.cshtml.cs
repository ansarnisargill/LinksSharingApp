using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkShareApp.Pages
{
    public class VerifyModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public Link Link { get; set; } = new Link();
        [BindProperty]
        public string code { get; set; } = "";
        public void OnGet(int Urlid,string Code)
        {
            code = Code;
            Link = _context.Links.Where(x=>x.ID==Urlid).First();
        }
        public VerifyModel(LinkAppContext context)
        {
            _context = context;
        }
    }
}
