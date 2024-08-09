using Microsoft.EntityFrameworkCore;

namespace Homework4_Solution.Models;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    public DbSet<Product> Products {get; set;}
}