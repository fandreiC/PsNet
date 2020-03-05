using MVCPentaStagiu01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace MVCPentaStagiu01.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        public ActionResult Index()
        {
            return View();
            //return RedirectToAction("Details");
        }

        //[HttpGet]
        //public ActionResult Details()
        //{
        //    //UserService us = new UserService();
        //    //List<UserModel> usmList= new List<UserModel>(us.GenerateList());
        //    //UserModel userModel = usmList[0];
        //    //UserViewModel userViewModel = new UserViewModel();
        //    //userViewModel= userModel.ToViewModel();

        //    var userViewModel = _userService.Get(1).ToViewModel();

        //    return View(userViewModel);
        //}

        [HttpGet]
        public ActionResult Details(int id)
        {
            UserModel userModel = _userService.Get(id);
            UserViewModel userViewModel = userModel.ToViewModel();

            //UserViewModel userViewModel = _userService.Get(id).ToViewModel();
           
            return View(userViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Description = "This is a create page for Users!";
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel )
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("List");            
        }

        [HttpGet]
        public ActionResult List()
        {
            List<UserModel> users = _userService.GetAll();
            List<UserViewModel> usersVM = users.Select(u => new UserViewModel()
            {
                Id= u.Id,
                FirstName = u.FirstName,
                Age=u.Age,
                Email=u.Email
            }).ToList();

            return View(usersVM);
        }
        

    }
}