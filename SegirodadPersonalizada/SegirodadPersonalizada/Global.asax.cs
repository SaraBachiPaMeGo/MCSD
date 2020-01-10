using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace SegirodadPersonalizada
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);        
        }

        //Tercer paso: crear al usuario en la sesión
        //SE TIENE QUE LLAMAR EL MÉTODO ASÍ
        public void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            //Si exite el ticket es que ha pasado por el login
            //Lo que significa que lo podemos meter en la sesión
            //Recuperamos la cookie 

            HttpCookie cookie = Request.Cookies["USERTICKET"]; //RECUPERAMOS EL NOMBRE DE LA COOKIE 
            //PARA BUSCARLA EN EL ARRAY 
            if (cookie != null)
            {
                //Recuperamos el valor cifrado de la cookie
                String datos = cookie.Value;
                //Recuperamos un ticket con estos datos
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(datos);

                //Tenemos que hacer el "principal" el tipo de clase que se utiliza para la validación
                //del usuario (dentro de V.S)
                //Un principal estará formado por un nombre (Identity) y un role/s (Puede pertenecer a varios roles)
                String role = ticket.UserData; 
                GenericPrincipal principal = new GenericPrincipal(new GenericIdentity(ticket.Name), new string[] {role});
                //GenericIdentity --> nombre del usuario que está en el ticket
                //new string[] { } --> No tenemos roles aún

                //GUARDAMOS EL USUARIO EN LA SESIÓN
                HttpContext.Current.User = principal;
            }


        }
    }
}
