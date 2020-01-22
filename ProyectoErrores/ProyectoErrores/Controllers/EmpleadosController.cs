using ProyectoErrores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoErrores.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController()
        {
            this.repo = new RepositoryEmpleados();
        }
        // GET: Empleados
        public ActionResult Index()
        {
            return View(repo.GetEmpleados());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int empno, String nombre, String oficio, int salario)
        {
            repo.Create(empno, nombre, oficio, salario);
            return RedirectToRoute("Index");
        }


        [Route("Delete")]
        public ActionResult Delete(int empno)
        {
            return View(repo.BuscarEmp(empno));
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delet(int empno)
        {
            repo.Delete(empno);
            return RedirectToRoute("Index");
        }
    }
}