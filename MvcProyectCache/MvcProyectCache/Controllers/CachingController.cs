using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProyectCache.Controllers
{
    public class CachingController : Controller
    {
        // GET: Caching
        public ActionResult Index()
        {
            return View();
        }

        //Get:HoraSistema
        //[OutputCache (Duration =5, VaryByParam ="dato")] //Expresado en segundos
        //Que mantenga el caché a no ser que se le pase el parámetro 
        // o cuando el parámetro cambie
        //Si ya hemos modificado el webconfig -->
        [OutputCache(CacheProfile ="corto")]
        public ActionResult HoraSistema(String dato)
        {
            ViewBag.Fecha = DateTime.Now.ToLongDateString()
                + " " + DateTime.Now.ToLongTimeString();
            //Indicamos cada cuanto tiempo queremos que se actualice la fecha
            //COGE EL CACHÉ, AUNQUE ACTUALICEMOS LA PÁGINA NO LEE LA INFORMACIÓN 
            //DEL CONTROLADOR

            return View();
        }

        //Añadir las claves en el webConfig en system.web
    }
}