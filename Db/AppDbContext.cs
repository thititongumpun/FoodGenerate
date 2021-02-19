using FoodGenerate.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodGenerate.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Food> Foods {get;set;}
    }
}