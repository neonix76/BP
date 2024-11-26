using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BP.Areas.Identity.Data;
using BP.Data;

namespace BP.Pages.Posts2
{
    public class EditModel : PageModel
    {
        private readonly BP.Data.ApplicationContext _context;

        public EditModel(BP.Data.ApplicationContext context)
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

            var post2 =  await _context.Posts2.FirstOrDefaultAsync(m => m.ID == id);
            if (post2 == null)
            {
                return NotFound();
            }
            Post2 = post2;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Post2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Post2Exists(Post2.ID))
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

        private bool Post2Exists(int id)
        {
            return _context.Posts2.Any(e => e.ID == id);
        }
    }
}
