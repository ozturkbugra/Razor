using Microsoft.EntityFrameworkCore;

namespace Razor.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BUGRA;Database=RazorDB;User Id=bugra;Password=123;TrustServerCertificate=True;");
        }
    }
}
