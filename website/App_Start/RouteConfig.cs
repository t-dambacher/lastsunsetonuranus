using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace LSOU.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            foreach (String view in new[] { "Actualites", "Medias", "Contacts" })
            {
                routes.MapRoute(
                    name: view,
                    url: view + "/",
                    defaults: new { controller = view, action = "Default" }
                );
            }

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Actualites", action = "Default" }
            );
        }
    }
}
