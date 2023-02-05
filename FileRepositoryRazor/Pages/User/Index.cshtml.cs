using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FileRepositoryRazor.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly FileRepositoryRazor.Data.FileRepositoryContext _context;

        public IndexModel(FileRepositoryRazor.Data.FileRepositoryContext context)
        {
            _context = context;
        }

        public IList<Models.User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}
