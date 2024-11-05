using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BP.Areas.Identity.Data;
using BP.Data;

namespace BP.Pages.Posts
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
        public Post Post { get; set; } = default!;
        public InputModel Input { get; set; }

        public class InputModel
        {
            public byte[] Picture { get; set; }
        }

            // For more information, see https://aka.ms/RazorPagesCRUD.
            public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
