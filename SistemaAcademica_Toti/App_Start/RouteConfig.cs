using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaAcademica_Toti
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                // Aqui estou definindo as minhas rotas
            routes.MapRoute(
                "sobre",
                "sobre",
                new { Controller = "Home", action = "about" }
                );

            routes.MapRoute(
                "contato",
                "contato",
                new { Controller = "Home", action = "contact" }
                );
            // aqui está defenido rota padrão de mvc
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
