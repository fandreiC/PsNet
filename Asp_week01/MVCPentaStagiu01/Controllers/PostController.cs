using MVCPentaStagiu01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPentaStagiu01.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            
            return View();
            //return RedirectToAction("Details");
        }

        [HttpGet]
        public ActionResult Details()
        {
            PostViewModel postViewModel = new PostViewModel
            {
                Id = 1,
                TimeOfPosting = DateTime.Now,
                Message = " THis is post nr 1",
                PostType = PostType.Text,
                IsSticky = true,
                Priority = 1
            };
            PostViewModel postViewModel2 = new PostViewModel
            {
                Id = 2,
                TimeOfPosting = DateTime.Now,
                Message = " THis is post nr 2",
                PostType = PostType.Photo,
                IsSticky = false,
                Priority = 2
            };
            List<PostViewModel> posts = new List<PostViewModel> 
            {     postViewModel ,  postViewModel2     };

            return View(postViewModel);
            //return View(posts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Description = "Create Post User Page !";
            return View();
        }

        [HttpPost]
        public ActionResult Create(PostViewModel postViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult List()
        {
            PostViewModel postViewModel = new PostViewModel
            {
                Id = 1,
                TimeOfPosting = DateTime.Now,
                Message = " THis is post nr 1",
                PostType = PostType.Text,
                IsSticky = true,
                Priority = 1
            };
            PostViewModel postViewModel2 = new PostViewModel
            {
                Id = 2,
                TimeOfPosting = DateTime.Now,
                Message = " THis is post nr 2",
                PostType = PostType.Photo,
                IsSticky = false,
                Priority = 2
            };

            IEnumerable<PostViewModel> posts = new List<PostViewModel>
            {     postViewModel ,  postViewModel2     };

            return View(posts);
        }


    }
}