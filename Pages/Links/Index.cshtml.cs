using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LinkShareApp.Models;

namespace LinkShareApp.Pages.Links
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class IndexModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;

        public IndexModel(LinkShareApp.Models.LinkAppContext context)
        {
            _context = context;
        }

        public IList<Link> Link { get;set; }

        public async Task OnGetAsync()
        {
            Link = await _context.Links.ToListAsync();
        }
    }
}
