using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacionCore.Filters
{
    public class AutentiAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Capturamos al usuario
            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                String accion = context.RouteData.Values["action"].ToString();
                String controler = context.RouteData.Values["controller"].ToString();

                //Recuperamos el tempdataprovider 
                //Recuperamos algo de la inyeción

                ITempDataProvider provider = (ITempDataProvider)
                    context.HttpContext.RequestServices
                    .GetService(typeof(ITempDataProvider));

                var TempData = provider.LoadTempData(context.HttpContext);
                TempData["action"] = accion;
                TempData["controller"] = controler;

                //Guardar el data
                provider.SaveTempData(context.HttpContext, TempData);

                RouteValueDictionary ruta = new RouteValueDictionary
                    (
                    new { 
                        controller= "Empleados",
                        action="LogIn"
                    });
                context.Result = new RedirectToRouteResult(ruta);
            }else
            {
                if (context.RouteData.Values["action"].ToString() == "Index")
                {
                    //El usuario existe y tiene un role
                    //user.IsInRole("ROLE")
                    if (user.IsInRole("PRESIDENTE") == false &&
                        user.IsInRole("DIRECTOR") == false &&
                        user.IsInRole("ANALISTA") == false)
                    {
                        RouteValueDictionary ruta = new RouteValueDictionary
                        (
                        new
                        {
                            controller = "Home",
                            action = "Error"
                        });
                        context.Result = new RedirectToRouteResult(ruta);
                    }
                }
            }
        }
    }
}
