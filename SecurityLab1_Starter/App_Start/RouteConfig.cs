using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        /*
        private static string GetAllControllersAsRegex()
        {
            var controllers = typeof(MvcApplication).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Controller)));
            var controllerNames = controllers.Select(c => c.Name.Replace("Controller", ""));
            return string.Format("({0})", string.Join("|", controllerNames));
        }
        private static string GetAllActionAsRegex()
        {
            var actions = typeof(MvcApplication).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Action)));
            var actionNames = actions.Select(c => c.Name.Replace("Action", ""));
            return string.Format("({0})", string.Join("|", actionNames));
        }
        */
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "emptyHome",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );

            routes.MapRoute(
                name: "ServerError",
                url: "Error/ServerError",
                defaults: new { controller = "Error", action = "ServerError"}
            );

            routes.MapRoute(
                name: "home",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "Home", action = "Index|About|Contact|GenError" }
            );

            routes.MapRoute(
                name: "inventory",
                url: "Inventory/{action}/{id}",
                defaults: new { controller = "Inventory", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name:"PageNotFound",
                url: "{*catchall}",
                new { controller = "Error", action = "NotFound", id = UrlParameter.Optional }
            );            
        }
    }
}
