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
            new Order{OrderId = 102, OrderDate=DateTime.Now, Product = "iPhone", Amount = 32, CustomerId = 3},
            new Order{OrderId = 103, OrderDate=DateTime.Now, Product = "Cups", Amount = 80, CustomerId = 3},
            new Order{OrderId = 104, OrderDate=DateTime.Now, Product = "Chairs", Amount = 90, CustomerId = 2},
            new Order{OrderId = 105, OrderDate=DateTime.Now, Product = "Hats", Amount = 45, CustomerId = 4}


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
        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order orders)
        {
            orderslist.Add(orders);
            return RedirectToAction("DisplayOrders");
        }

    }
}
