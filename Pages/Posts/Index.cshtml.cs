using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BP.Areas.Identity.Data;
using BP.Data;

namespace BP.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly BP.Data.ApplicationContext _context;

        public IndexModel(BP.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Post = await _context.Posts.ToListAsync();
        }
    }
}
