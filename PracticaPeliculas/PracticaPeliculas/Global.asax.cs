using PracticaPeliculas.Models;
using PracticaPeliculas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace PracticaPeliculas
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

        public void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            //Recuperamos la cookie
            HttpCookie cookie = Request.Cookies["COOKIE"];

            if (cookie!=null)
            {
                //Desencriptamos el valor de la cookie para recuperar el ticket
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

                //Buscamos al usuario
                RepositoryPelis repo = new RepositoryPelis();

                Cliente cli = repo.BuscarClienteXX(int.Parse(ticket.Name));
                String role="";

                //Guardamos al usuario en la session
                ClientePrincipal user = new ClientePrincipal(
                    new GenericIdentity(cli.Nombre),role);

                user.IdCliente = cli.IdCliente;
                user.Nombre = cli.Nombre;
                user.Imagen_Cliente = cli.Imagen_Cliente ;
                user.Email=cli.Email  ;
                user.PaginaWeb =cli.PaginaWeb ;

                HttpContext.Current.User = user;

            }
            
        }
    }
}
