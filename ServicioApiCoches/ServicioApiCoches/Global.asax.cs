using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ServicioApiCoches
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.
                SupportedMediaTypes.Clear();            
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    //Añadimos en la abecera de la petición el acceso
        //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-ORigin","*");

        //    //Preguntamos por el tipo de opciones de peticion
        //    //en la cabecera
        //    //Debemos indicar que aceptamos las peticiones
        //    if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        //    {
        //        //Podemos indicar el acceso a más métodos
        //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST,PUT,DELETE");

        //        //Aceptar las peticiones en la cabecera
        //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Context-Type: Accept");

        //        //Indicamos que le daremos acceso por tiempo
        //        HttpContext.Current.Response.AddHeader("Allow-Control-Max-Age", "1728000");
        //        HttpContext.Current.Response.End();
        //    }
        //}
    }
}
