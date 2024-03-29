using Microsoft.EntityFrameworkCore;
using Repository.Data.Entities;

namespace Repository.Data
{
    public class CompanyDbContext : DbContext 
    {
        public CompanyDbContext() 
        { }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) 
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee {
                    Id = 1,
                    Level = 1,
                    Firstname = "Tandi",
                    Lastname = "Sunarto",
                    DepartmentId = 1
                },
                new Employee {
                    Id = 2,
                    Level = 1,
                    Firstname = "Suyenti",
                    Lastname = "Sunarto",
                    DepartmentId = 2
                },
                new Employee {
                    Id = 3,
                    Level = 2,
                    Firstname = "Scarlet",
                    Lastname = "Sunarto",
                    DepartmentId = 3
                }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department {
                    Id = 1,
                    Name = "Household Head",
                },
                new Department {
                    Id = 2,
                    Name = "Household Finance",
                },
                new Department {
                    Id = 3,
                    Name = "Member",
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}