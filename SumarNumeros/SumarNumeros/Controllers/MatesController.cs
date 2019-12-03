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

        public ActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SumarNumeros(int? numero1, int? numero2)
        {
            //numero1.GetValueOrDefault(); // Coge el valor predeterminado de un null, 
            //en caso del int es 0
            int? suma = numero1 + numero2;
            ViewBag.Dato = suma;
            return View();
        }
        [HttpPost]
        public ActionResult Multiplicar(int? num)
        {
            List<int?> tablaMulti = new List<int?>();
            for (int i = 1; i<=10; i++) {
                int? resul = num * i;
                tablaMulti.Add(resul);
            }
            return View(tablaMulti);
        }

        public ActionResult GenerarNumeros() {

            List<int> numAlea = new List<int>();
            Random alea = new Random();

            for (int i = 1; i <= 5; i++) {
                
                int num = alea.Next(1,10);
                numAlea.Add(num);
            }
            return View(numAlea);
        }

        public ActionResult TablaGet(int Parametro) {
            ViewBag.Dato = Parametro;
            List<int> tablaMulti = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int resul = Parametro * i;
                tablaMulti.Add(resul);
            }
            return View(tablaMulti);
        }
    }
}