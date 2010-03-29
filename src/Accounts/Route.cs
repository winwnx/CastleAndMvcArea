using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounts
{
    public class Routes : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Accounts"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Accounts_Default",
                "Profile/{action}/{id}",
                new { controller = "Accounts", action = "Index", id = "" }
            );
        }
    }

}
