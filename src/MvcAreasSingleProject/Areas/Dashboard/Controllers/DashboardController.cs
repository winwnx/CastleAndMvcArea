using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAreasSingleProject.Models;

namespace MvcAreasSingleProject.Areas.Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        private string _name;

        public DashboardController(string name)
        {
            _name = name;
        }
        public ActionResult AddPost()
        {
            ViewData["Name"] = "Dashboard from castle";
            return View();
        }

        public ActionResult EditPost()
        {
            return View();
        }

        public ActionResult Test()
        {
            var model = new TestModel();
            model.NameForDDL = "Name_bb";

            return View(model);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Test(TestModel model)
        {
            return View(model);
        }


    }
}
