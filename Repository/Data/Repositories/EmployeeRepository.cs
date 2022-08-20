using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Entities;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;

namespace Repository.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public CompanyDbContext dbContext { get; }

        public IEnumerable<Employee> GetEmployees()
        {
            return null;
        }
        
        public override IEnumerable<Employee> List()
        {
            return dbContext.Set<Employee>().Include(d => d.Department).ToList();
        }
    }
}