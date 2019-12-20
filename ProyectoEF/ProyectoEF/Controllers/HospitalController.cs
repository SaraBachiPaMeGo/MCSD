using ProyectoEF.Models;
using ProyectoEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoEF.Controllers
{
    public class HospitalController : Controller
    {
        RespositoryHospital repo;
        public HospitalController() 
        {
            repo = new RespositoryHospital();
        }
        // GET: Hospital
        public ActionResult Index()
        {
            List<Hospital> listaHospi = repo.GetHospitales();
            return View(listaHospi);
        }

        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Hospital hospi)
        {
            repo.CrearHospital(hospi.CodHospi, hospi.Nombre, hospi.Direccion, hospi.Tlf, hospi.NumCamas);
            return RedirectToAction("Index");
        }
    }
}