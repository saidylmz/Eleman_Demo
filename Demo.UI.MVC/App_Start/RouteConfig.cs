using Demo.BLL.Abstract;
using Demo.UI.MVC.Tools.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Demo.UI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("Advert",
                "{*permalink}",
                new { action = "Index", controller = "Advert" },
                new { permalink = new AdvertConstraint(DependencyResolver.Current.GetService<IAdvertService>()) }
                );
            routes.MapRoute(
                name: "Login",
                url: "giris-yap",
                defaults: new { controller = "Account", action = "Login" }
            );
            routes.MapRoute(
                name: "Logout",
                url: "cikis-yap",
                defaults: new { controller = "Account", action = "LogOut" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
