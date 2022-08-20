using Microsoft.AspNetCore.Mvc;
using Repository.Data.Entities;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;
using Repository.Models;

namespace Repository.Controllers
{
    public class EmployeeController : Controller
    {
        private IBaseRepository<Employee> employeeRepository;
        private readonly IUnitOfWork uow;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            employeeRepository = unitOfWork.EmployeeRepository;
            uow = unitOfWork;
        }
        public IActionResult List()
        {
            var employees = employeeRepository.List();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public Employee Add(AddEmployeeModel model)
        {
            var employee = employeeRepository.Insert(new Employee 
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Level = model.Level
                });
            uow.SaveChanges();
            return employee;
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = employeeRepository.Get(Id);
            EditEmployeeModel model = new EditEmployeeModel {
                Id = employee.Id,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Level = employee.Level,
            };
            uow.SaveChanges();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditEmployeeModel model)
        {
            employeeRepository.Update(new Employee
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Level = model.Level
            });
            uow.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            var employee = employeeRepository.Get(Id);
            employeeRepository.Delete(employee);
            uow.SaveChanges();           
            return RedirectToAction("List");
        }
    }
}