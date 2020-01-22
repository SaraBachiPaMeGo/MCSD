using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMvcEneroAjax.Controllers
{
    //Si utilizamos esto debemos utilizar Route en todos sus action
    //[RoutePrefix("Casa")]
    public class HomeController : Controller
    {
        //[Route]
        public ActionResult Index()
        {
            return View();
        }
        //[Route("Algo")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //[Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}