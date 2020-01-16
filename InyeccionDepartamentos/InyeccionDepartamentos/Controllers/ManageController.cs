using InyeccionDepartamentos.Models;
using InyeccionDepartamentos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionDepartamentos.Controllers
{
    public class ManageController : Controller
    {
        RepositoryHospital repo;
        public ManageController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        // GET: Manage
        public ActionResult Index()
        {
            return View(repo.GetDepartamentos());
        }

        public ActionResult Edit(int num)
        {
            return View(repo.BuscarDepartamento(num));
        }

        [HttpPost]

        public ActionResult Edit(Departamento dep)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateDepartamento(dep.Dept_no, dep.DNombre, dep.Loc);
                return RedirectToAction("Index");
            }
            else 
            {
                ViewBag.DatosIncorrectos = "Datos Incorrectos";
                return View();
            }
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Departamento dep)
        {
            if (ModelState.IsValid)
            {
                repo.InsertarDept(dep.Dept_no, dep.DNombre,dep.Loc);
                return RedirectToAction("Index");
            }
            else 
            {
                ViewBag.DatosIncorrectos = "Datos Incorrectos";
                return View();
            }            
        }
    }
}