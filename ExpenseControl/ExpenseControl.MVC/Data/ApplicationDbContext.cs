using ExpenseControl.MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpenseControl.MVC.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Card> Cards { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Expense> Expenses { get; set; }
}
