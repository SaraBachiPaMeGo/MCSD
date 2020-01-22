using ProyectoMvcEneroAjax.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMvcEneroAjax.Controllers
{
    public class HospitalesController : Controller
    {
        RepositoryHospital repo;

        public HospitalesController()
        {
            this.repo = new RepositoryHospital();
        }

        // GET: Hospitales
        public ActionResult Index()
        {
            return View(repo.GetHospitales());
        }

        [Route("Delete")] //ENRRUTAR EL GET Y POST

        public ActionResult Delete(int hospiCod)
        {
            return View(repo.BuscarHospi(hospiCod));
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Eliminar(int hospiCod)
        {
            repo.DeleteHospi(hospiCod);
            return RedirectToAction("Index");
        }
    }
}