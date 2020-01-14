using SeguridadEmpleados.Authorization;
using SeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadEmpleados.Controllers
{
    
    public class EmpleadoController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadoController()
        {
            this.repo = new RepositoryEmpleados();
        }

        public ActionResult EmpleadosOficio(String oficio)
        {
            return View(repo.GetEmpleadosOficio(oficio));
        }
        [ChildActionOnly] //Es una decoración para las vistas parciales
        //Para indicar que es una vista parcial
        //si no lo ponemos igualmente va
        public ActionResult _MenuOficios()
        {
            return PartialView(repo.GetOficios());
        }

        [Autorizacion]
        // GET: Empleado
        public ActionResult Index()
        {
            return View(repo.GetEmpleados());
        }
    }
}