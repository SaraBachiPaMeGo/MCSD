using ExamenMVCSaraBachiller.App_Start;
using ExamenMVCSaraBachiller.Data;
using ExamenMVCSaraBachiller.Models;
using ExamenMVCSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace ExamenMVCSaraBachiller
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IoCConfiguration.RegistrarDependencias();
        }
        public void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["COOKIE"];

            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

                IRepository repo =
                   DependencyResolver.Current.GetService<IRepository>();

                Usuario user = repo.BuscarUsuarioId(int.Parse(ticket.Name));

                UsuarioPrincipal userppal = new UsuarioPrincipal( new GenericIdentity (user.Nombre),"");

                userppal.IdUsuario = user.IdUsuario;
                userppal.Nombre = user.Nombre;
                userppal.Apellidos = user.Apellidos;
                userppal.Email = user.Email;
                userppal.Foto = user.Foto;
                userppal.Pass = user.Pass;

                HttpContext.Current.User = userppal;
            }
        }
    }
}
