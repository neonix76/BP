using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BP.Areas.Identity.Data;
using BP.Data;

namespace BP.Pages.Posts2
{
    public class CreateModel : PageModel
    {
        private readonly BP.Data.ApplicationContext _context;

        public CreateModel(BP.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Post2 Post2 { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts2.Add(Post2);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
