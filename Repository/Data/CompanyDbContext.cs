using Microsoft.EntityFrameworkCore;
using Repository.Data.Entities;

namespace Repository.Data
{
    public class CompanyDbContext : DbContext 
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) 
            :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}