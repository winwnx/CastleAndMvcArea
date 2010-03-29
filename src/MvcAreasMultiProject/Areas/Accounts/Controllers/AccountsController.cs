using System.Web.Mvc;

namespace MvcAreasMultiProject.Areas.Accounts.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditBilling()
        {
            return View();
        }

        public ActionResult EditShipping()
        {
            return View();
        }


    }
}
