using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ForumSystem.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /threads/tagged/javascript
            routes.MapRoute(
                name: "Threads by tag",
                url: "threads/tagged/{tag}",
                defaults: new { controller = "Threads", action = "GetByTag" }
            );

            // /threads/threadID/thread-title
            routes.MapRoute(
                name: "Display thread",
                url: "threads/{id}/{url}",
                defaults: new { controller = "Threads", action = "Display" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
