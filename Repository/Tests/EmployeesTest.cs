// using NUnit.Framework;
// using Repository.Data.Entities;
// using Repository.Data.Repositories;

// namespace Repository.Tests
// {
//     public class EmployeesTest
//     {
//         private EmployeeRepository employeeRepo;
//         private Employee employee;

//         public EmployeesTest(EmployeeRepository employeeRepo)
//         {
//             this.employeeRepo = employeeRepo;
//         }

//         [SetUp]
//         public void Setup()
//         {
//             employee = new Employee {
//                 Id = 1,
//                 Firstname = "Tandi",
//                 Lastname = "Sunarto",
//                 Level = 63
//             };
//         }

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
//     }
// }