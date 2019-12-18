using ProyectoPruebaPractica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPruebaPractica.Controllers
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
            return View(repo.GetEmpleados());
        }

        [HttpPost]

        public ActionResult Index(String name, String campo)
        {
            if (name == "asc")
            {
                return View(repo.GetEmpleadosOrdenados(1,campo));
            }
            else if(name == "desc")
            {
                return View(repo.GetEmpleadosOrdenados(0,campo));
            }
            else { 
                return View(repo.GetEmpleadosOrdenados(1,campo));
            }
        }
    }
}