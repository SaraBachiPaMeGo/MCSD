using ProyectoMVCDatos.Models;
using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleado repo;

        public EmpleadosController() {
            repo = new RepositoryEmpleado();
        }
        // GET: Empleados
        public ActionResult Index()
        {
            List<String> oficios = repo.GetOficios();
            ViewBag.Oficios = oficios;
            return View();
        }
        
        //Pulsar botón: POST
        [HttpPost]

        public ActionResult Index(String oficio)
        {
            ViewBag.Oficios = repo.GetOficios();
            List<EMP> listaEmp = repo.GetEmpleado(oficio);
            return View(listaEmp);
        }

        

    }
}