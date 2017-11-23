using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RecipeForDisaster
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Frontpage", action = "FrontPage", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}",
                defaults: new { controller = "Account", action = "LoginPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SignUp",
                url: "{controller}/{action}",
                defaults: new { controller = "Account", action = "SignUp", id = UrlParameter.Optional }
            );

            routes.MapRoute(

                name: "LoginScript",
                url: "{controller}/{action}",
                defaults: new { controller = "LoginScript", action = "LoginScript", id = UrlParameter.Optional }
            );
            
            
        }
    }
}
