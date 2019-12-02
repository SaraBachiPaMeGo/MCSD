using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumarNumeros.Controllers
{
    public class MatesController : Controller
    {
        // GET: Mates
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SumarNumeros(int? numero1, int? numero2)
        {
            int? suma = numero1 + numero2;
            ViewBag.Dato = suma;
            return View();
        }

        public ActionResult Multiplicar(int? num)
        {
            List<int?> tablaMulti = new List<int?>();
            for (int i = 1; i<=10; i++) {
                int? resul = num * i;
                tablaMulti.Add(resul);
            }
            return View(tablaMulti);
        }
    }
}