using System.Collections.Generic;
using Repository.Data.Entities;
using Repository.Data.Interfaces;

namespace Repository.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext DbContext) : base(DbContext)
        {
        }

        public List<Employee> GeFulltimeEmployee()
        {
            throw new System.NotImplementedException();
        }
    }
}