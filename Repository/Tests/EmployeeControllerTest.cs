using Moq;
using NUnit.Framework;
using Repository.Controllers;
using Repository.Data;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;
using Repository.Models;

namespace Repository.Tests;

public class EmployeeControllerTest
{
	private Mock<CompanyDbContext> dbContext;
	private IUnitOfWork uow;
	private Mock<IEmployeeRepository> employeeRepo;
	private AddEmployeeModel employee;

	private EmployeeController employeeController;

	public EmployeeControllerTest()
	{ 
	}

	[SetUp]
	public void Setup()
	{
		// employeeRepo = new Mock<IEmployeeRepository>()
		
		dbContext = new Mock<CompanyDbContext>();
		uow = new UnitOfWork(dbContext.Object);

		employeeController = new EmployeeController(uow);

		employee = new() {
			Firstname = "Tandi",
			Lastname = "Sunarto",
			Level = 63,
			DepartmentId = 1
		};
	}

	[Test]
	public void CanAddEmployee()
	{

		uow.SaveChanges();

		dbContext.Verify(c => c.SaveChanges());
		// var count = employeeController.Add(employee);

		// Assert.AreEqual(1, count);
	}


//         [Test]
//         public void TestInsertEmployee()
//         {
//             var count = employeeRepo.Insert(employee);

//             Assert.AreEqual(1, count);
//         }

//         [Test]
//         public void TestDeletetEmployee()
//         {
//             employeeRepo.Delete(employee);

//             Assert.Pass();
//         }
}