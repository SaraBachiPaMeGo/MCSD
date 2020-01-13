using SeguridadEmpleados.Authorization;
using SeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadEmpleados.Controllers
{
    [Autorizacion]
    public class EmpleadoController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadoController()
        {
            this.repo = new RepositoryEmpleados();
        }
        // GET: Empleado
        public ActionResult Index()
        {
            return View(repo.GetEmpleados());
        }
    }
}