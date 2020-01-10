using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SeguridadDoctores.Authorization
{
    public class AutorizacionAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            //FILTRO PARA VER SI ESTAMOS VALIDADOS EN LA SESION
            if (filterContext.HttpContext.Request.IsAuthenticated == false)
            {
                //SI NO, REDIRECCIONAMOS CON ROUTEDICTIONARY
                RouteValueDictionary ruta = new RouteValueDictionary(new
                {
                    controller = "Manage",
                    action = "Login"
                });
                filterContext.Result = new RedirectToRouteResult(ruta);
            }

            

            
        }
    }
}