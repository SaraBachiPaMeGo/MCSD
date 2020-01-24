using ProyectoErrores.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProyectoErrores
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters
                (GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }

        //Cuando no hemos cogido las excepciones
        //protected void Application_Error()
        //{
        //    //Tenemos información del error
        //    //El último error
        //    Exception ex = Server.GetLastError();

        //    HttpException httpex = ex as HttpException;

        //    //Dependiendo de la excepcion (code), enviaremos
        //    //al action 404 o al otro
        //    String action = "";

        //    if (httpex.GetHttpCode() == 404)
        //    {
        //        action = "Error404";
        //    }
        //    else
        //    {
        //        action = "ErrorGeneral";
        //    }

        //    //Como personalizamos la exception debemos limpiar el context
        //    Context.ClearError();

        //    RouteData ruta = new RouteData();

        //    ruta.Values.Add("controller", "Error");
        //    ruta.Values.Add("action", action);

        //    //Se puede hacer tambien con redirectoroute

        //    IController controller = new ErrorController();

        //    //Que se ejecute el controlador con una petición
        //    //EXECUTE CON SU CLASE
        //    controller.Execute(new RequestContext(
        //        new HttpContextWrapper(Context), ruta));

            
        //}
    }
}
