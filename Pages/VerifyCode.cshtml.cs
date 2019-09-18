using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LinkShareApp.Pages
{
    public class VerifyCodeModel : PageModel
    {
        private readonly LinkAppContext _context;
        [BindProperty]
        public string Message { get; set; } = "";

        public IActionResult OnGet(int id,string code)
        {
            var IsAutehntic = false;
            var Code = _context.Codes.Include(x=>x.Link).Where(x => x.CodeTerm == code.Trim()).FirstOrDefault();
            if (Code != null)
            {
                if (Code.LinkId == id && Code.ValidTill >= DateTime.Now)
                {
                    IsAutehntic = true;
                }
            }
            
            if (IsAutehntic)
            {
              return  Redirect(Code.Link.Url);
            }
            else
            {
                this.Message = "Code You entered is invalid!";    
            }
            return Page();
        }
        public VerifyCodeModel(LinkAppContext context)
        {
            _context = context;
        }
    }
}