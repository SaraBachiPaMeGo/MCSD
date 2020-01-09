using MvcProyectCache.Models;
using MvcProyectCache.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProyectCache.Controllers
{
    public class SesionesController : Controller
    {
        RepositoryEmpleados repo;

        public SesionesController() 
        {
            this.repo = new RepositoryEmpleados();
        }

        //GET: AlmacenarSalarios
        public ActionResult AlmacenarSalarios()
        {
            List<Empleado> empleados = repo.GetEmpleados();
            return View(empleados);
        }

        // GET: Sesiones
        public ActionResult Index()
        {
            return View();
        }
    }
}