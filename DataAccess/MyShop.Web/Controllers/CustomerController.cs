using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyShop.Domain.Models;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Interfaces;

namespace MyShop.Web.Controllers
{
    public class CustomerController : Controller
    {
        private IRepository<Customer> customRepository;

        // private ShoppingContext context;

        public CustomerController(IRepository<Customer> customRepository)
        {
            this.customRepository = customRepository;
            // context = new ShoppingContext();
        }

        public IActionResult Index(Guid? id)
        {
            if (id == null)
            {
                var customers = customRepository.All();

                return View(customers);
            }
            else
            {
                // var customer = context.Customers.Find(id.Value);
                var customer = customRepository.Get(id.Value);

                return View(new[] { customer });
            }
        }
    }
}
