using Microsoft.AspNetCore.Mvc;
using CustomersApp.Models;

namespace CustomersApp.Controllers
{
    public class OrdersController : Controller
    {
        static List<Order> orderslist = new List<Order>
        {
            new Order{OrderId = 100, OrderDate=DateTime.Now, Product = "Laptops", Amount = 20, CustomerId = 1},
            new Order{OrderId = 101, OrderDate=DateTime.Now, Product = "Hoover", Amount = 32, CustomerId = 2},
                        new Order{OrderId = 102, OrderDate=DateTime.Now, Product = "iPhone", Amount = 32, CustomerId = 3}
        };
        public IActionResult DisplayOrders()
        {
            return View(orderslist);
        }
        public IActionResult DisplayRelated(int id)
        {
            if (id == null)
            {
                return RedirectToAction("DisplayOrders");
            }
            // LINQ
            var emp = (from x in orderslist where x.CustomerId == id select x);
            if (emp == null)
            {
                return RedirectToAction("DisplayOrders");
            }
            return View(emp);
        }
    }
}
