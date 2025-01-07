using Microsoft.AspNetCore.Mvc;
using CustomersApp.Models;
namespace CustomersApp.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> customerslist = new List<Customer>
        {
            new Customer{CustomerId = 1, CustomerName="Bader", CustomerEmail = "Bader@gmail.com", CustomerCity = "Riyadh", Phone = 5556672, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= true},
             new Customer{CustomerId = 2, CustomerName="Ali", CustomerEmail = "Ali@gmail.com", CustomerCity = "Kuwait", Phone = 34567890, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= true},
              new Customer{CustomerId = 3, CustomerName="Nora", CustomerEmail = "Nora@gmail.com", CustomerCity = "Dubai", Phone = 987654, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= true}
        };

        public IActionResult DisplayCustomers ()
        {
            return View(customerslist);
        }

        public IActionResult Details (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("DisplayCustomers");
            }
            // LINQ
            var emp = (from x in customerslist where x.CustomerId == id select x).SingleOrDefault();
            if (emp == null)
            {
                return RedirectToAction("DisplayCustomers");
            }
            return View(emp);
        }
    }
}
