using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LinkShareApp.Models;

namespace LinkShareApp.Pages.Codes
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class DeleteModel : PageModel
    {
        private readonly LinkShareApp.Models.LinkAppContext _context;

        public DeleteModel(LinkShareApp.Models.LinkAppContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Code = await _context.Codes.FindAsync(id);

            if (Code != null)
            {
                _context.Codes.Remove(Code);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
