using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SeguridadEmpleados.Authorization
{
    public class AutorizacionAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            //Recuperamos al usuario
            EmpleadoPrincipal user = HttpContext.Current.User as EmpleadoPrincipal;
                        
            if (user!=null)
            {  //Preguntamos por su rol 
                //Presidente, director y analistas
                if (user.IsInRole("ANALISTA") == false
                    && user.IsInRole("DIRECTOR") == false
                    && user.IsInRole("PRESIDENTE") == false
                   )
                {
                    filterContext.Result = GetRoute("SinAcceso", "Manager");
                }
            }
            else
            {
                //Capturamos el action que se haya activado
                String action = filterContext.RouteData.Values["action"].ToString();

                //Qué control ha hecho la petición
                String controller =
                filterContext.RouteData.Values["controller"].ToString();

                //Cómo enviamos esta informacion hasta el controller de Manager?
                // session --> Ocupa más memoria
                //TempData pertenece a los controladores pero desde filtercontext
                //podemos acceder a todo de un controller
                filterContext.Controller.TempData["ACTION"] = action;
                filterContext.Controller.TempData["CONTROLLER"] = controller;                

                //No existe, lo llevamos a login
                filterContext.Result = GetRoute("Login", "Manager");
            }

        }

        //Hacemos un método para que nos devuelva la ruta (el action y el controller)
        public RedirectToRouteResult GetRoute(String accion, String controlador)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(
                new
                {
                    controller = controlador,
                    action = accion
                }
                );
            return new RedirectToRouteResult(ruta);
        }
    }
}