using ProyectoEntityFramework.Models;
using ProyectoEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoEntityFramework.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamento repo;
        ModeloDepartamento modelo;

        public DepartamentosController() {
            repo = new RepositoryDepartamento();
            modelo = new ModeloDepartamento();
        }

        // GET: Departamentos
        public ActionResult Index()
        {
            return View(repo.GetDepartamentos());
        }
        [HttpPost]

        public ActionResult Index(int deptno)
        {
            return View(repo.GetDepartamentos());
        }

        public ActionResult Modificar(int deptno)
        {
            return View(repo.BuscarDept(deptno));
        }

        [HttpPost]

        public ActionResult Modificar(int deptno, String nombre, String loc)
        {
            repo.ModificarDepartamento(deptno, nombre, loc);
            return RedirectToAction("Index"); ;
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Crear(int deptno, String nombre, String loc)
        {
            repo.InsertarDepartamento(deptno, nombre, loc);
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int deptno)
        {
            repo.EliminarDepartamento(deptno);
            return RedirectToAction("Index");
        }

        public ActionResult PaginarDepartamentos(int? posicion)
        { 
            if (posicion == null)
            {
                posicion = 1;
            }

            PAGINAR_DEPT_Result dept = modelo.PaginarDepartamentos(posicion.GetValueOrDefault());

            int ultimo = modelo.GetNumeroDepartamentos();

            //DEBEMOS VERIFICAR QUE NO NOS PASAMOS PARA SIGUIENTE 

            int siguiente = posicion.GetValueOrDefault() + 1;

            if (siguiente > ultimo)
            {
                siguiente = ultimo;
            }

            //VERIFICAMOS ANTERIOR TAMBIEN 

            int anterior = posicion.GetValueOrDefault() - 1;

            if (anterior < 1)
            {
                anterior = 1;
            }

            ViewBag.Siguiente = siguiente;
            ViewBag.Anterior = anterior;
            ViewBag.Ultimo = ultimo;

            return View(dept);
        }
    }
}