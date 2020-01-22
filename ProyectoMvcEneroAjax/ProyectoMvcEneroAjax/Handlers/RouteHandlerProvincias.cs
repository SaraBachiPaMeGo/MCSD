using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ProyectoMvcEneroAjax.Handlers
{
    public class RouteHandlerProvincias : IRouteHandler
    {
        private List<String> Provincias;
        public RouteHandlerProvincias(List<String> provincias)
        {
            this.Provincias = provincias;
        }
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new HttpHandlerProvincias(Provincias, requestContext);
        }
    }
}