﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LinkShareApp.Models;

namespace LinkShareApp.Pages.Codes
{
    public class DetailsModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;

        public DetailsModel(LinkShareApp.Models.LinkAppContext context)
        {
            _context = context;
        }

        public Code Code { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Code = await _context.Codes
                .Include(c => c.Link).FirstOrDefaultAsync(m => m.ID == id);

            if (Code == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
