using SeguridadEmpleados.Models;
using SeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace SeguridadEmpleados
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
            HttpCookie cookie = Request.Cookies["EMPLEADO"];
            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                //idEmpleado (ticket.name)
                //oficio -->(Userdata) ROLE
                RepositoryEmpleados repo = new RepositoryEmpleados();

                Empleados emp = repo.BuscarEmp(int.Parse(ticket.Name));//Objeto que queremos guardar 
                //en la sesion
                List<String> roles = new List<string>();
                roles.Add(emp.Oficio); //Añadimos todos los oficios a roles. Esto se hace por si algún usuario 
                //tiene dos roles

                //Creamos el ppal para añadirla a la sesión
                EmpleadoPrincipal user = new EmpleadoPrincipal(
                    new GenericIdentity(emp.Nombre),
                    roles);
                user.Nombre = emp.Nombre;
                user.Emp_no = emp.Emp_no;
                user.Oficio = emp.Oficio;
                user.Salario = emp.Salario;

                HttpContext.Current.User = user; 
                //Creamos una clase que here de iprincipal, porque user necesita un objeto y un generic ppal
            }
        }
    }
}
