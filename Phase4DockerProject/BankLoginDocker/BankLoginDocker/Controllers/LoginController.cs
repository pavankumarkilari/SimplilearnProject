using Microsoft.AspNetCore.Mvc;

namespace BankLoginDocker.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "Pavan" && password == "Pavan@1234")
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("Login");
            }
            
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
