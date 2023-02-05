using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FileRepositoryRazor.Data;
using FileRepositoryRazor.Models;

namespace FileRepositoryRazer.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly FileRepositoryRazor.Data.FileRepositoryContext _context;

        public DetailsModel(FileRepositoryRazor.Data.FileRepositoryContext context)
        {
            _context = context;
        }

      public FileRepositoryRazor.Models.User User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
