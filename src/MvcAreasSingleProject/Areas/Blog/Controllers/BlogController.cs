using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreasSingleProject.Areas.BlogA.Controllers.Big
{
    public class BlogController : Controller
    {
        private readonly BlogData _data;

        public BlogController(BlogData data)
        {
            _data = data;
        }

        public ActionResult ShowRecent()
        {
            ViewData["BlogName"] = _data.BlogName;
            return View();
        }

        public ActionResult ShowArchive()
        {
            return View();
        }


    }
}
