﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");

            routes.MapRoute(
                            name: "RegExpValidation",
                            url: "RegularExpression",
                            defaults: new { controller = "RegularExpression", action = "Index", id = UrlParameter.Optional }
                            );
            
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Home1",
                url: "Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Home2",
                url: "TestHome",
                defaults: new { controller = "Home", action = "Test", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "CurrentTime",
                url: "CurrentTime",
                defaults: new { controller = "Home", action = "CurrentTime", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Customer",
                url: "Customer",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
                );

            
            routes.MapRoute(
                            name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

                        );

        }
    }
}
