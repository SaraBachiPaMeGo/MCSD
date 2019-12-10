using ProyectoMVCDatos.Models;
using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class IncrementoDeptController : Controller
    {
        RepositoryDepartamentos repo;

        public IncrementoDeptController() {
            repo = new RepositoryDepartamentos();
        }
        // GET: IncrementoDept
        public ActionResult Index()
        {
            ViewBag.Dept = repo.GetDepartamentos();
            return View();
        }
        [HttpPost]
        public ActionResult Index(int incr, int numero)
        {
            ViewBag.Dept = repo.GetDepartamentos();
            repo.ModificarEmpleados(incr, numero);
            List<EMP> listaEmp =repo.GetEmpleadosDepartamento(numero);
            return View(listaEmp);
        }
    }
}