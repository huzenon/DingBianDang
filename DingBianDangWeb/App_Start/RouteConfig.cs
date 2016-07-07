using System.Web.Mvc;
using System.Web.Routing;

namespace DingBianDangWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "default",
                "{controller}/{action}",
                new { controller = "Home", action = "Index" }
            );
        }
    }
}
