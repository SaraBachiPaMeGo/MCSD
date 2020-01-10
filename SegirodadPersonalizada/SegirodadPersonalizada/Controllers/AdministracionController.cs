using SegirodadPersonalizada.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegirodadPersonalizada.Controllers
{
    public class AdministracionController : Controller
    {
        [AutorizacionSimple]
        // GET: Administracion
        public ActionResult Index()
        {
            return View();
        }
    }
}