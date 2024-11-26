using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BP.Areas.Identity.Data;
using BP.Data;

namespace BP.Pages.Posts2
{
    public class DeleteModel : PageModel
    {
        private readonly BP.Data.ApplicationContext _context;

        public DeleteModel(BP.Data.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Post2 Post2 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post2 = await _context.Posts2.FirstOrDefaultAsync(m => m.ID == id);

            if (post2 == null)
            {
                return NotFound();
            }
            else
            {
                Post2 = post2;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post2 = await _context.Posts2.FindAsync(id);
            if (post2 != null)
            {
                Post2 = post2;
                _context.Posts2.Remove(Post2);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
