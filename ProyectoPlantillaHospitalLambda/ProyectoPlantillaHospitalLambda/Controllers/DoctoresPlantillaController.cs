using ProyectoPlantillaHospitalLambda.Models;
using ProyectoPlantillaHospitalLambda.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPlantillaHospitalLambda.Controllers
{
    public class DoctoresPlantillaController : Controller
    {

        RepositoryHospital repo;

        public DoctoresPlantillaController() {
            repo = new RepositoryHospital();
        }
        // GET: DoctoresPlantilla
        public ActionResult Index()
        {
            List<HOSPITAL> listaHospitales = repo.GetHospitales();
            ViewBag.Hospitales = listaHospitales;
            return View();
        }

        [HttpPost]

        public ActionResult Index(int hospi_cod)
        {
            List<HOSPITAL> listaHospitales = repo.GetHospitales();
            ViewBag.Hospitales = listaHospitales;
            return View(repo.GetDoctorPlantilla(hospi_cod));
        }

        public ActionResult Prueba()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Prueba(String dato)
        {
            ViewBag.Dato = dato;
            return View();
        }

    }
}