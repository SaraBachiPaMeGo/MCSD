using ProyectoMVCDatos.Models;
using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamentos repo;
        public DepartamentosController() {
            this.repo = new RepositoryDepartamentos();
        }
        //ADMINISTRA PETICIONES
        // GET: Departamentos
        public ActionResult Index()
        {
            List<DEPT> listDepartamentos= repo.GetDepartamentos();

            return View(listDepartamentos);
        }

        //GET: Delete
        public ActionResult Delete() {
            //List<DEPT> listDepartamentos = repo.EliminarDepto();
            return View(repo.GetDepartamentos());
        }

        //POST: Delete --> Cuando le das al botón
        [HttpPost]
        public ActionResult Delete(int deptno)
        {
            repo.EliminarDepto(deptno);
            return View(repo.GetDepartamentos());
        }

        public ActionResult Resumen()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Resumen(int deptno)
        {
            ResumenDepartamentos resu = repo.GetResumenDepartamento(deptno);
            return View(resu);
        }
    }
}