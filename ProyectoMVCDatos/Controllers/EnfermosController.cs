using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class EnfermosController : Controller
    {
        RepositoryEnfermo repo;
        public EnfermosController() {
            repo = new RepositoryEnfermo();
        }

        // GET: Enfermos
        public ActionResult Index()
        {
            return View(repo.GetEnfermos());
        }

        public ActionResult Editar(int insc)
        {
            return View(repo.BuscarEnfermo(insc));
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editar(int insc, String apellido, 
            String direccion, DateTime fecha_nac, String s, int nss) 
        {
            repo.Modificar(insc, apellido, direccion, fecha_nac, s, nss);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Crear(int insc, String apellido, 
            String direccion, DateTime fecha_nac, String s, int nss)
        {
            repo.Crear( insc,  apellido,  direccion,  fecha_nac,  s,  nss);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Eliminar(int insc)
        {
            repo.Eliminar(insc);
            return RedirectToAction("Index");
        }

        
    }
}