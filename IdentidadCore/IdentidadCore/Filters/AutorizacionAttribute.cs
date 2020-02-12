using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentidadCore.Filters
{
    public class AutorizacionAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Capturamos al usuario
            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                //Llevamos al usuario al login 
                RouteValueDictionary ruta = new RouteValueDictionary
                (
                    new
                    {
                        controller = "Manage",
                        action = "LogIn"
                    });
                context.Result = new RedirectToRouteResult(ruta);
            }
            //else
            //{ 
            
            //}
        }
    }
}
