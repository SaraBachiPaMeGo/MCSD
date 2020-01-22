using ProyectoMvcEneroAjax.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoMvcEneroAjax
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Mapear rutas dentro de los controllers o los action

            //routes.MapMvcAttributeRoutes();
            List<String> bloqueos = new List<string>();
            bloqueos.Add("Cuenca");
            bloqueos.Add("Murcia");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            {
                // SIN MAPMVC
                //routes.MapRoute(
                //    name: "EliminarHospital",
                //    url: "Hospitales/Delete",
                //    defaults: new
                //    {
                //        controller = "Hospitales",
                //        action = "Eliminar",
                //        constrainsts = new
                //        {
                //            httpMethod = new HttpMethodConstraint("POST")                        
                //        }
                //    }
                //    ) ;

                //routes.MapRoute(
                //    name:"RutaBuscar",
                //    url: "Rutas/{tipoaccion}/{iddato}",
                //    defaults : new { 
                //        controller ="Rutas",
                //        action = "Buscar",
                //        tipoaccion = "",
                //        id=""
                //    }
                //    );

            }
            RouteTable.Routes.Add("RutaProvincias",
                new Route("Provincias/Region/{nombreprovincia}",
                new RouteHandlerProvincias(bloqueos))
                ) ;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", 
                    id = UrlParameter.Optional
                }
            );

        }
    }
}
