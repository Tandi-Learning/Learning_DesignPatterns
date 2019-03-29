using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;

namespace Repository.Controllers
{
    public class CustomerController : Controller
    {
        private IMapper _mapper;

        public CustomerController(
            IMapper mapper
        )
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            AdventureWorks2017Context dbContext = new AdventureWorks2017Context();

            // var customers = dbContext.Customer.Select(c => new CustomerViewModel
            // {
            //     AccountNumber = c.AccountNumber,
            //     ModifiedDate = c.ModifiedDate
            // });
            var result = dbContext.Customer.Include(c => c.Territory).ToList();

            var vm = _mapper.Map<IEnumerable<CustomerViewModel>>(result);
            return View(vm);
        }

        public IActionResult Products()
        {
            AdventureWorks2017Context dbContext = new AdventureWorks2017Context();

            var result = dbContext.Product.ToList();

            var vm = _mapper.Map<IEnumerable<ProductViewModel>>(result);
            return View(vm);
        }
    }
}