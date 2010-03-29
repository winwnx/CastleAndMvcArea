using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store
{
    public class Routes : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Store"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Store_Default",
                "Store/{controller}/{action}/{id}",
                new { controller = "Products", action = "List", id = "" }
            );
        }
    }

}
