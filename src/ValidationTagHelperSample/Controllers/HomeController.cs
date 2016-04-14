using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ValidationTagHelperSample.Controllers
{
    public class User
    {
        [Required]
        public string UserName1 { get; set; }

        [Required]
        public string UserName2 { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index");

            return View(user);
        }
    }
}
