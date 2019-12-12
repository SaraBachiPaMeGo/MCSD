using ProyectoEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoEntityFramework.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleaddo repo;
        public EmpleadosController() {
            repo = new RepositoryEmpleaddo();
        }
        // GET: Empleados
        public ActionResult SeleccionMultiple()
        {
            List<String> listaOfi =repo.GetOficios();
            ViewBag.Oficios = listaOfi;
            return View();
        }

        [HttpPost]

        public ActionResult SeleccionMultiple(String [] oficio, int incr)
        {
            List<String> listaOfi = repo.GetOficios();
            ViewBag.Oficios = listaOfi;
            
            //Tenemos que pasar de array a una lista

            List<String> oficios = oficio.OfType<String>().ToList();

            repo.IncrementarSalario(oficios, incr);

            return View(repo.GetEmpleados(oficios));
        }
    }
}