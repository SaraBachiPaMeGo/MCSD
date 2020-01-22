using ProyectoMvcEneroAjax.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace ProyectoMvcEneroAjax.Controllers
{
    public class AjaxController : Controller
    {
        RepositoryHospital repo;
        public AjaxController()
        {
            repo = new RepositoryHospital();
        }
        //Tendremos un ActionResult asociado a una
        //vista parcial para llamarlo desde AJAX

        public ActionResult PlantillaHospital(int hospiCod)
        {
            return PartialView(repo.GetPlantillas(hospiCod));
        }
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hospitales()
        {
            String cnn = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            ViewBag.Cadena = cnn;
            return View(repo.GetHospitales());
        }

        public ActionResult AllPlantillas()
        {
            return View(repo.GetPlantillasAll());
        }

        public ActionResult Details(int idPlantilla)
        {
            return PartialView(repo.DetallesPlantilla(idPlantilla));
        }
        public ActionResult Delete(int idPlantilla)
        {
            repo.Delete(idPlantilla);
            return RedirectToAction("AllPlantillas");
        }

    }
}