using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MvcAreasSingleProject.Areas.Dashboard.Controllers;
using MvcAreasSingleProject.Controllers;
using MvcContrib.Castle;

namespace MvcAreasSingleProject
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        private static void RegisterWindsor()
        {
            var container = new WindsorContainer();
            var types = typeof(HomeController).Assembly.GetTypes();
            container.Register(Component.For<BlogData>());

            foreach (var controller in
                types.Where(t => typeof(IController).IsAssignableFrom(t)))
            {
                container.Register(
                        Component.For(controller)
                            .LifeStyle.Transient);
            }

            var dict = new Hashtable {{"name", "This is My Dashboard"}};
            container.Kernel.RegisterCustomDependencies(typeof (DashboardController), dict);

            var cf = new WindsorControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(cf);


        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);

            RegisterWindsor();
        }
    }
}