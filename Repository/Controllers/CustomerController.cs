using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;

public class CustomerController : Controller 
{
    public IActionResult Index()
    {
        AdventureWorks2017Context dbContext = new AdventureWorks2017Context();

        var customers = dbContext.Customer.Select(c => new CustomerViewModel {
            AccountNumber = c.AccountNumber, 
            ModifiedDate = c.ModifiedDate
        });
        return View(customers);
    }
}