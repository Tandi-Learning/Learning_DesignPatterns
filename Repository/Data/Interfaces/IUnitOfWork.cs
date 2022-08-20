using Repository.Data.Entities;

namespace Repository.Data.Interfaces;

public interface IUnitOfWork
{
	IBaseRepository<Department> DepartmentRepository {get; }
	IBaseRepository<Employee> EmployeeRepository {get; }
	void SaveChanges();
}