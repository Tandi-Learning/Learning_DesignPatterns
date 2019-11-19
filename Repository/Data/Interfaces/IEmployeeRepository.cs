using System.Collections.Generic;
using Repository.Data.Entities;

namespace Repository.Data.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        List<Employee> GeFulltimeEmployee();
    }
}