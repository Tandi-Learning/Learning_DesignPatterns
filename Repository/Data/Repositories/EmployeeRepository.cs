using System.Collections.Generic;
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
        }

        public List<Employee> GeFulltimeEmployee()
        {
            throw new System.NotImplementedException();
        }
    }
}