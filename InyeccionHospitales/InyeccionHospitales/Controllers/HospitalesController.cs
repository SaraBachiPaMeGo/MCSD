using InyeccionHospitales.Models;
using InyeccionHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionHospitales.Controllers
{
    public class HospitalesController : Controller
    {
        IRepositoryHospital repo;
        public HospitalesController(IRepositoryHospital repo) // controller depende de repo
        {
            this.repo = repo;
        }
        // GET: Hospitales
        public ActionResult Index()
        {
            return View(repo.GetHospitales());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Hospital hospi)
        {
            repo.InsertarHospitales(hospi.IdHospital,
            hospi.Nombre, hospi.Direccion,
            hospi.Telefono, hospi.Camas);
            return RedirectToAction("Index");
        }
    }
}