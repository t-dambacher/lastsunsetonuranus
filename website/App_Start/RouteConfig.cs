using LSOU.Web.Models.Menu;
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
            const String defaultAction = "Default";

            foreach (MenuItem view in Menu.Current)
            {
                routes.MapRoute(
                    name: view.Name,
                    url: view.Url,
                    defaults: new { controller = view.Name, action = defaultAction }
                );
            }

            MenuItem defaultItem = Menu.Current.GetDefaultItem();
            routes.MapRoute(
                name: defaultAction,
                url: "{controller}/{action}",
                defaults: new { controller = defaultItem.Name, action = defaultAction }
            );
        }
    }
}
