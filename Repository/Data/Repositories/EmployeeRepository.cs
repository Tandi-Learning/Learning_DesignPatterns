using System.Collections.Generic;
using System.Linq;
using Repository.Data.Entities;
using Repository.Data.Interfaces;
using Repository.Repositories;

namespace Repository.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(
            CompanyDbContext dbContext,
            UnitOfWork uow) : 
            base(dbContext, uow)
        {
            this.dbContext = dbContext;
        }

        public CompanyDbContext dbContext { get; }

        public IEnumerable<Employee> GetEmployees()
        {
            return null;
        }
    }
}