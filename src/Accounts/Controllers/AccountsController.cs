using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounts.Controllers
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
