using ProyectoMVCDatos.Models;
using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class DoctoresController : Controller
    {
        RepositoryDoctor repo;
        public DoctoresController() {
            repo = new RepositoryDoctor();
        }
        // GET: Doctores
        public ActionResult Index()
        {            
            return View(repo.GetDoctor());
        }

        //GET: CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(DOCTOR doc) {
            repo.InsertarDoctor(doc.HOSPITAL_COD.GetValueOrDefault(), doc.DOCTOR_NO,
                doc.APELLIDO, doc.ESPECIALIDAD, doc.SALARIO.GetValueOrDefault()); //Un int no puede ser null sino 0
            //return View();
            return RedirectToAction("Index");
        }

        public ActionResult Detalles(int id)
        {            
            return View(repo.BuscarDoctor(id));
        }
        //GET:Editar
        public ActionResult Editar(int id)
        {            
            return View(repo.BuscarDoctor(id));
        }

        [HttpPost]

        public ActionResult Editar(int hospicod,int id, String apellido, String especialidad, int salario)
        {
            repo.ModificarDoctor(hospicod, id, apellido, especialidad,salario);
            //return View(repo.BuscarDoctor(id));
            return RedirectToAction("Index");
        }

        [HttpGet]

        public ActionResult Eliminar(int id) 
        {
            repo.EliminarDoctor(id);
            //Solo para vistas sin modelos --> return View("Index"); Nombre de la vista que queremos que vaya
            //Action para que lea el código. Necesitamos el método redirectoaction
            return RedirectToAction("Index");
        }
        
    }
}