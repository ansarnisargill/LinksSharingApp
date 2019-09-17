using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkShareApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public List<Link> ListOfLinks { get; set; } = new List<Link>();
        public void OnGet()
        {
            ListOfLinks = _context.Links.ToList();
        }
        public IndexModel(LinkAppContext context)
        {
            _context = context;
        }
    }
}
