using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoErrores
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ErrorSalario",
                url: "Empleados/ErrorSalarios/{msj}",
                defaults: new
                {
                    controller = "Empleados",
                    action = "ErrorSalarios",
                    msj = UrlParameter.Optional
                }
                );

            routes.MapRoute(
                name: "EliminarEmpleados",
                url: "{controller}/{action}/{id}",
                defaults:
                new
                {
                    controller = "Empleados",
                    action = "Eliminar",
                    constrainsts =
                    new
                    {
                        httpMethod = new HttpMethodConstraint("POST")
                    }
                }
                ) ;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
