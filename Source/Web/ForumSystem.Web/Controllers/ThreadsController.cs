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
        // /threads/threadID/thread-title
        public ActionResult Display(int id, string url, int page = 1)
        {
            return View();
        }

        // /threads/threadID/thread-title
        public ActionResult GetByTag(string tag)
        {
            return View();
        }

        // GET - POST - REDIRECT
        [HttpGet]
        public ActionResult Ask()
        {
            return Content("Get");
        }

        [HttpPost]
        public ActionResult Ask(AskInputModel input)
        {
            return Content("Post");
        }
	}
}