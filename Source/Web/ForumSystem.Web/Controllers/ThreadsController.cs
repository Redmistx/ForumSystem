using ForumSystem.Data.Common.Repository;
using ForumSystem.Data.Models;
using ForumSystem.Web.InputModels.Threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumSystem.Web.Controllers
{
    public class ThreadsController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public ThreadsController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        // /threads/threadID/thread-title
        public ActionResult Display(int id, string url, int page = 1)
        {
            return Content(id.ToString());
        }

        // /threads/threadID/thread-title
        public ActionResult GetByTag(string tag)
        {
            return View();
        }

        // GET - POST - REDIRECT
        [HttpGet]
        public ActionResult Create()
        {
            var model = new CreateInputModel();
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateInputModel input)
        {
            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Title = input.Title,
                    SomeShit = input.Content,
                    // TODO: tags
                };

                this.posts.Add(post);
                this.posts.SaveChanges();
                return this.RedirectToAction("Display", new { id = post.Id, url = "to-be-written" });
            }

            return View(input);
        }
	}
}