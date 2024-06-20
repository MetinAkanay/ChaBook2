using ChaBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaBook.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View("Register");
        }
        public IActionResult Login()
        {
            return View("Login");
        }

    }
}
