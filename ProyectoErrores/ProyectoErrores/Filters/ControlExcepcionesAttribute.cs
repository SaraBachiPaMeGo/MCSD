using ProyectoErrores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoErrores.Filters
{
    //FilterAttritbute nos permite poder incerceptar 
    //peticiones entre View y controller ,, indicar dónde
    //IExceptionFilter filtro para incerceptar Exceptiones
    public class ControlExcepcionesAttribute : FilterAttribute, IExceptionFilter //Para decorar e interceptar FILTERATT
    {
        public void OnException(ExceptionContext filterContext)
        {
            //ENTRARÁ CON LAS EXCEPCIONES
            //Preguntamos si hemos manegado la excepcion (con try-catch)

            if (filterContext.ExceptionHandled == false) {

                //Mensaje de la exception
                String mensaje = filterContext.Exception.Message;

                //Podemos especificar el action y el controller
                String controller = filterContext.RouteData.Values["controller"].ToString();

                RepositoryEmpleados repo = new RepositoryEmpleados();
                //Implementar como deseamos tratar el control de errores
                //en la App
                // Una es logging
                // Otra BBDD
                repo.InsetarExcepcion(mensaje, controller, DateTime.Now);

                //Indicamos a la App que ya hemos manegado/controlado
                //la excepción
                filterContext.ExceptionHandled = true;

                //Indicar a dónde queremos ir
                //Haremos la misma redireccion que hemos hecho en 
                //seguridad con redirectoaction
                RouteValueDictionary ruta = new RouteValueDictionary(
                        new
                        {
                            controller = "Empleados",
                            action = "ErrorSalarios",
                            msj = mensaje
                        });
                filterContext.Result = new RedirectToRouteResult(ruta);
            }
        }
    }
}