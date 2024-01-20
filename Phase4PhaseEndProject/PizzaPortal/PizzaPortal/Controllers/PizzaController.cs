using Microsoft.AspNetCore.Mvc;
using PizzaPortal.Models;

namespace PizzaPortal.Controllers
{
    public class PizzaController : Controller
    {
        static public List<Pizza> pizzadetails = new List<Pizza>()
        {
         new Pizza { PizzaId = 100,Type = "Vegetarian Pizza", Price =25},
         new Pizza { PizzaId = 101,Type = "Margherita",Price=45},
         new Pizza { PizzaId = 103,Type = "Pepproni ",Price=20},
         new Pizza { PizzaId = 104,Type = "Cheese Pizza ",Price=50}
        };
        static public List<Order> orderdetails = new List<Order>();
        public IActionResult Index()
        {

            return View(pizzadetails);
        }
        public IActionResult Cart(int id)
        {
            var found = (pizzadetails.Find(p => p.PizzaId == id));
            TempData["id"] = id;
            return View(found);
        }
        [HttpPost]
        public IActionResult Cart(IFormCollection f)
        {
            Random r = new Random();
            int id = Convert.ToInt32(TempData["id"]);
            Order o = new Order();
            var found = (pizzadetails.Find(p => p.PizzaId == id));
            o.OrderId = r.Next(100, 999);
            o.PizzaId = id;
            o.Price = Convert.ToInt32(pizzadetails.Find(p => p.Price == id));
            o.Type = found.Type;
            o.Quantity = Convert.ToInt32(Request.Form["qty"]);
            o.TotalPrice = o.Price * o.Quantity;
            orderdetails.Add(o);
            return RedirectToAction("Checkout");
        }
        public IActionResult Checkout()
        {
            return View(orderdetails);
        }
    }
}
