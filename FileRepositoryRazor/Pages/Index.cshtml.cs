using FileRepositoryRazor.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FileRepositoryRazor.Pages;

public class RegisterModel : PageModel
{

    private readonly ILogger<RegisterModel> _logger;

    private readonly FileRepositoryContext _context;
    
    public RegisterModel(ILogger<RegisterModel> logger, FileRepositoryContext context)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        var user = new Models.User
        {
            FirstName = "John",
            Surname = "Doe",
            Nickname = "johndoe",
            Password = "password",
            Email = "johndoe@example.com"
        };
        
        AddUser(user);
    }
    
    private void AddUser(Models.User user)
    {
        _context.Add(user);
        _context.SaveChanges();
    }
}