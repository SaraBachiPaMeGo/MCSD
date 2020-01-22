using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ProyectoMvcEneroAjax.Handlers
{
    public class HttpHandlerProvincias : IHttpHandler
    {
        private List<String> Provincias;
        private RequestContext RequestContext;
        public HttpHandlerProvincias(List<String> provincias, RequestContext requestContext)
        {
            this.Provincias = provincias;
            this.RequestContext = requestContext;
        }
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            //Procesar la petición
            //La que vamos a recibir va a ser Provincias/Region/Sevilla
            //Quermeos capturar la palabra Sevilla
            //Se puede hacer con RouteData[controlador,action]

            //RawUrl --> nos devuelve Provincias/Sevilla
            //String url = context.Request.RawUrl;

            RouteValueDictionary rutas = this.RequestContext.RouteData.Values;
            String nombreProv = rutas["nombreprovincia"].ToString();

            //Bloquemos una serie de provincias según nuestra lista
            if (Provincias.Contains(nombreProv))
            {
                //Bloqueamos con un error
                //Podemos también redirigir a otra página por ejemplo
                context.AddError(new Exception("Provincia Bloqueada:" + nombreProv));
            }
            else
            { 
                //Busco la última barra y me quedo con el final
                //int barra = url.LastIndexOf("/") +1;
                //String nombreProvincia = url.Substring(barra);
                String wikipedia = "https://es.wikipedia.org/wiki/" + nombreProv;
                context.Response.Redirect(wikipedia,true); // true --> Finalizamos
                //la respuesta porque salimos de nuestra app             
            }


            
        }
    }
}