using ProyectoErrores.Filters;
using ProyectoErrores.Models;
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
            ViewBag.Oficios = repo.GetOficios();
            return View( repo.GetEmpleados());
        }

        [ControlExcepciones]
        [HttpPost]
        public ActionResult Create(int empno, String nombre, String oficio, int dir,int salario, int dept_no)
        {
            //Comprobar algunas características:
            //1-. Un empleado no puede cobrar mas que su jefe
            
            Empleado jefe = repo.BuscarEmp(dir);

            if (salario >= jefe.Salario)
            {
                throw new Exception("El empleado" + nombre + " no puede cobrar más que su jefe" + jefe.Nombre+
                     "Salario máximo: "+ jefe.Salario);
            }

            //2.- Un empleado no puede cobrar negativo o 0
            if (salario <= 0)
            {
                throw new Exception("El empleado " + nombre + " no puede tener salario 0 o negativo");
            }

            repo.Create(empno, nombre, oficio,dir, salario, dept_no);
            return RedirectToAction("Index");
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

        public ActionResult ErrorSalarios()
        {
            String message = RouteData.Values["msj"].ToString();
            //HttpContext.Request.RequestContext.Route.....
            ViewBag.Mensaje = message;
            return View();
        }
    }
}