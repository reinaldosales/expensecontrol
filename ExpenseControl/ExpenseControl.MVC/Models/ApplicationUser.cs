using Microsoft.AspNetCore.Identity;

namespace ExpenseControl.MVC.Models;

public class ApplicationUser : IdentityUser
{
    public string Avatar { get; set; }
}
