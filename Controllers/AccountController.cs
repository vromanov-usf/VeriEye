using Microsoft.AspNetCore.Mvc;

namespace VeriEye.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return RedirectToAction("Dashboard", "Customers");
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(string fullName, string email, string password, string confirmPassword)
        {
            return RedirectToAction("Dashboard", "Customers");
        }
    }
}