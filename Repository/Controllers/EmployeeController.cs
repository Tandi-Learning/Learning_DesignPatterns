using Microsoft.AspNetCore.Mvc;
using Repository.Data.Entities;
using Repository.Data.Repositories;
using Repository.Models;

namespace Repository.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult List()
        {
            var employees = _employeeRepository.List();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeModel model)
        {
            _employeeRepository.Insert(new Employee 
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Level = model.Level
                });
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _employeeRepository.Get(Id);
            EditEmployeeModel model = new EditEmployeeModel {
                Id = employee.Id,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Level = employee.Level,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditEmployeeModel model)
        {
            _employeeRepository.Update(new Employee
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Level = model.Level
            });
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            var employee = _employeeRepository.Get(Id);
            _employeeRepository.Delete(employee);
            return RedirectToAction("List");
        }
    }
}