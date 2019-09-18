using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LinkShareApp.Models;

namespace LinkShareApp.Pages.Codes
{
    public class EditModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;

        public EditModel(LinkShareApp.Models.LinkAppContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["LinkId"] = new SelectList(_context.Links, "ID", "Description");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Code).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeExists(Code.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CodeExists(int id)
        {
            return _context.Codes.Any(e => e.ID == id);
        }
    }
}
