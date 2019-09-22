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
    public class IndexModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;
        public IndexModel(LinkShareApp.Models.LinkAppContext context)
        {
            _context = context;
        }

        public List<LinkDTO> Link { get; set; }

        public async Task OnGetAsync()
        {
            Link = await _context.Links.Select(x => new LinkDTO { ID = x.ID, Url = x.Url, UrlName = x.UrlName, Description = x.Description, PricePerDay = x.PricePerDay, FacebookLink = "http://linksshareapp.herokuapp.com/Verify/" + x.ID }).ToListAsync();
        }
    }
}
