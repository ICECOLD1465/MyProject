using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}