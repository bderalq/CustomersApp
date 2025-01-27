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
            CustomerIsDeleted = false, CustomerIsActive= false},
              new Customer{CustomerId = 4, CustomerName="Ahmad", CustomerEmail = "Ahmad@gmail.com", CustomerCity = "Bahrain", Phone = 34262781, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= true},
              new Customer{CustomerId = 5, CustomerName="Shaikha", CustomerEmail = "Shaikha@gmail.com", CustomerCity = "Kuwait", Phone = 987654, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= false},
              new Customer{CustomerId = 6, CustomerName="Saleh", CustomerEmail = "Saleh@gmail.com", CustomerCity = "Basra", Phone = 987654, CustomerDate =DateTime.Now,
            CustomerIsDeleted = false, CustomerIsActive= true}
        };

        public IActionResult DisplayCustomers ()
        {
            return View(customerslist);
        }

        public IActionResult Details(int? id)
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
        [HttpGet]
        public IActionResult Create ()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create (Customer customer)
        {
            customerslist.Add(customer);
            return RedirectToAction("DisplayCustomers");
        }

        public IActionResult IsActive()
        {
            return View(customerslist); 
        }
        public IActionResult NotActive()
        {
            return View(customerslist);
        }


    }
}
