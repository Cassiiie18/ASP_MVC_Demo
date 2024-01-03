using DevNetCloud.Models;
using DevNetCloud.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevNetCloud.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RegisterForm user)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Password);
                return View("Index");
            }

            Console.WriteLine("Formulaire pas bien rempli !");

            return View();
        }
    }
}