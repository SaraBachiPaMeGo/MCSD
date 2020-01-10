using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SegirodadPersonalizada.Authorization
{
    public class AutorizacionSimpleAttribute
        :AuthorizeAttribute // Puesto a mano
    {
        //Aquí en donde tenemos que interceptar las peticiones
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            //Preguntamos si estamos validados            
            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                GenericPrincipal user = (GenericPrincipal) HttpContext.Current.User;
                //Aquí podríamos preguntar sobre datos del usuario (Role...)
                //Mediante el método IsInRole(ROLE) podemos preguntar por el rol de un 
                //user
                if (user.IsInRole("ADMINISTRADOR") == false)
                {
                    // Nos lo llevamos a sin acceso o lo llevamos a login
                    RouteValueDictionary ruta =
                        new RouteValueDictionary(new
                        {
                            controller = "Manage",
                            action = "ErrorAcceso"
                        });
                    filterContext.Result = new RedirectToRouteResult(ruta);
                }                
            }
            else
            {
                //Debemos redireccionar a Login
                //Para poder enviar a otras direcciones necesitamos rutas
                //Una ruta está compuesta por un controller y un action
                RouteValueDictionary rutaLogin = 
                    new RouteValueDictionary(new 
                    { 
                        controller = "Manage",
                        action = "Login"
                    });

                //Redireccionamos a la ruta indicada
                filterContext.Result = new RedirectToRouteResult(rutaLogin);
            }
        }
    }
}