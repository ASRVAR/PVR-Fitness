using GYM.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogin _loginUser;
        public AuthController(ILogin loguser)
        {
            _loginUser = loguser;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string passcode)
        {
            var issuccess = _loginUser.AuthenticateUser(username, passcode);


            if (issuccess.Result != null)
            {
                ViewBag.username = string.Format("Successfully logged-in", username);

                TempData["username"] = "Ahmed";
                return RedirectToAction("Index", "Banner");
            }
            else
            {
                ViewBag.username = string.Format("Login Failed ", username);
                return View();
            }
        }
    }
}
