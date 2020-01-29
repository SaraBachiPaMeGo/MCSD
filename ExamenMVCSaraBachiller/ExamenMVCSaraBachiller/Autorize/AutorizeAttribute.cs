using ExamenMVCSaraBachiller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExamenMVCSaraBachiller.Autorize
{
    public class AutorizeAttribute : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            UsuarioPrincipal user = HttpContext.Current.User as UsuarioPrincipal;

            if (user != null)
            {
                String action = filterContext.RouteData.Values["action"].ToString();
                String controller = filterContext.RouteData.Values["controller"].ToString();

                filterContext.Controller.TempData["action"] = action;
                filterContext.Controller.TempData["controller"] = controller;
            }
            else {
                filterContext.Result = GetRuta("LogIn", "Libros");
            }
        }

        public RedirectToRouteResult GetRuta(String accion, String controler)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(
                new
                {
                    controller = controler,
                    action = accion
                });
            return new RedirectToRouteResult(ruta);
        }
    }
}