using System.Web.Mvc;

namespace MvcAreasMultiProject.Store
{
    public class StoreRoutes : AreaRegistration
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
