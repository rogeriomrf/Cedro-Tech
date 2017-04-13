using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaDeRestaurantes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/",
                defaults: new { controller = "Home", action = "Index" }

            );

            routes.MapRoute(
                name: "Restaurantes",
                url: "Restaurantes/",
                defaults: new { controller = "Restaurantes", action = "Index" }
            );

            routes.MapRoute(
                name: "Busca Restaurantes",
                url: "Restaurantes/Busca/",
                defaults: new { controller = "Restaurantes", action = "Busca" }
            );

            routes.MapRoute(
                name: "Detalhes Restaurantes",
                url: "Restaurantes/Detalhes/{id}",
                defaults: new { controller = "Restaurantes", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cadastrar Restaurantes",
                url: "Restaurantes/Cadastrar/",
                defaults: new { controller = "Restaurantes", action = "Create" }
            );

            routes.MapRoute(
                name: "Editar Restaurantes",
                url: "Restaurantes/Editar/{id}",
                defaults: new { controller = "Restaurantes", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Excluir Restaurantes",
                url: "Restaurantes/Excluir/{id}",
                defaults: new { controller = "Restaurantes", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Pratos",
                url: "Pratos/",
                defaults: new { controller = "Pratos", action = "Index" }
            );

            routes.MapRoute(
                name: "Detalhes Pratos",
                url: "Pratos/Detalhes/{id}",
                defaults: new { controller = "Pratos", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cadastrar Pratos",
                url: "Pratos/Cadastrar/",
                defaults: new { controller = "Pratos", action = "Create" }
            );

            routes.MapRoute(
                name: "Editar Pratos",
                url: "Pratos/Editar/{id}",
                defaults: new { controller = "Pratos", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Excluir Pratos",
                url: "Pratos/Excluir/{id}",
                defaults: new { controller = "Pratos", action = "Delete", id = UrlParameter.Optional }
            );
        }
    }
}
