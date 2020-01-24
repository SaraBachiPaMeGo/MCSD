using ProyectoErrores.Filters;
using System.Web;
using System.Web.Mvc;

namespace ProyectoErrores
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            
            //Añadimos el filtro
            filters.Add(new ControlExcepcionesAttribute());
        }
    }
}
