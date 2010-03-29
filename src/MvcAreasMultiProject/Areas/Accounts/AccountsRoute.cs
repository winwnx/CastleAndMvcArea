using System.Web.Mvc;

namespace MvcAreasMultiProject.Areas.Accounts
{
    public class AccountsRoutes : AreaRegistration
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
