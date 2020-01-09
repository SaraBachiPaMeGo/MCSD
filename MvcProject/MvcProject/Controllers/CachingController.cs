using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CachingController : Controller
    {
        // GET: Caching
        public ActionResult Index()
        {
            return View();
        }

        //GET: HoraSistema
        //[OutputCache(Duration=15, VaryByParam ="dato")]
        [OutputCache(CacheProfile ="corto")]
        public ActionResult 
            HoraSistema(String dato)
        {
            ViewBag.Fecha =
                DateTime.Now.ToLongDateString()
                + " "
                + DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}