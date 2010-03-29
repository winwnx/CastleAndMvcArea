using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreasSingleProject.Areas.Blog
{
    public class BlogRoutes : AreaRegistration 
    {
        public override string AreaName
        {
            get { return "blog"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "blog_default",
                "blog/{controller}/{action}/{id}",
                new { controller = "Blog", action = "ShowRecent", id = "" }
            );
        }

    }
}
