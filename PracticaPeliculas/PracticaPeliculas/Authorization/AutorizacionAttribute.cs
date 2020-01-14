using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PracticaPeliculas.Authorization
{
    public class AutorizacionAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                //RouteValueDictionary ruta = new RouteValueDictionary(
                //    new
                //    {
                //        controller = "Manage",
                //        action = "Perfil" //Tiene que ser dinámico
                //    }
                //    );
                //filterContext.Result = new RedirectToRouteResult(ruta);
            }
            else
            {
                RouteValueDictionary ruta = new RouteValueDictionary(
                    new
                    {
                        controller = "Manage",
                        action = "LogIn"
                    }
                    );
                filterContext.Result = new RedirectToRouteResult(ruta);
            }

        }
    }
}