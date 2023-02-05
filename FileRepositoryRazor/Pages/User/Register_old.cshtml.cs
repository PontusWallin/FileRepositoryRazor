using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FileRepositoryRazor.Data;
using FileRepositoryRazor.Models;
using Microsoft.AspNetCore.Identity;

namespace FileRepositoryRazor.Pages.User_second_test
{
    public class RegisterModel : PageModel
    {
        private readonly FileRepositoryRazor.Data.FileRepositoryContext _context;

        public RegisterModel(FileRepositoryRazor.Data.FileRepositoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public Models.User User { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Users == null || User == null)
            {
                return Page();
            }
            
            
            var passwordHasher = new PasswordHasher<IdentityUser>();
            User.Password = passwordHasher.HashPassword(null, User.Password);

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}