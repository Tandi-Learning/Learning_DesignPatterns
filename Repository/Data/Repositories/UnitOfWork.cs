using Repository.Data.Entities;
using Repository.Data.Interfaces;

namespace Repository.Data.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private CompanyDbContext dbContext;
    private IBaseRepository<Department> departmentRepository;
    private IBaseRepository<Employee> employeeRepository;

    public UnitOfWork(CompanyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IBaseRepository<Department> DepartmentRepository {
        get {
            if (departmentRepository is null) 
                departmentRepository = new DepartmentRepository(dbContext);

            return departmentRepository;
        }
    }

    public IBaseRepository<Employee> EmployeeRepository {
        get {
            if (employeeRepository is null) 
                employeeRepository = new EmployeeRepository(dbContext);

            return employeeRepository;
        }
    }

    public void SaveChanges()
    {
        dbContext.SaveChanges();
    }
}