﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;

        public DetailsModel(LinkShareApp.Models.LinkAppContext context)
        {
            _context = context;
        }

        public Link Link { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Link = await _context.Links.FirstOrDefaultAsync(m => m.ID == id);

            if (Link == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
