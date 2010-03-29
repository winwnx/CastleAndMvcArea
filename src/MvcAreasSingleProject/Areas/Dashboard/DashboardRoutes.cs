using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAreasSingleProject.Areas.Dashboard
{
    public class DashboardRoutes : AreaRegistration
    {
        public override string AreaName
        {
            get { return "dashboard"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "dashboard_default",
                "dashboard/{controller}/{action}/{id}",
                new { controller = "Dashboard", action = "AddPost", id = "" }
            );
        }
    }

}
