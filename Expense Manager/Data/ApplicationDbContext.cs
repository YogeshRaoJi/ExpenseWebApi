using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Manager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Expense_Manager.Models.Category> Category { get; set; }
    }
}
