using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mysqlAppWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Personne", action = "Create", id = UrlParameter.Optional }  // Parameter defaults
            );
            /*routes.MapRoute(
                "Login",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Login", action = "Index", id = UrlParameter.Optional }  // Parameter defaults
            );*/

        }
    }
}
