using SeguridadEmpleados.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadEmpleados.Controllers
{
    [Autorizacion]
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ActionResult Index()
        {
            return View();
        }
    }
}