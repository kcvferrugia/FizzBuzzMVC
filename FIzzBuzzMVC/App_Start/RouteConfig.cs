using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FIzzBuzzMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//url address. action always needs to correspond to method in controller
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//menu bar links
            );
        }
    }
}
