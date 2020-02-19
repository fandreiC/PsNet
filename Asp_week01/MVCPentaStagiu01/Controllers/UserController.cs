using MVCPentaStagiu01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPentaStagiu01.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("Details");
        }

        [HttpGet]
        public ActionResult Details()
        {
            UserViewModel userViewModel = new UserViewModel
            {
                Age = 17,
                FirstName = "Hulk"
            };
            return View(userViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Description = "This is a create page !";
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel )
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index");
            
        }

    }
}