using ProyectoMVCDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCDatos.Controllers
{
    public class HospitalPlantillaController : Controller
    {
        RepositoryHospital repo;
        public HospitalPlantillaController() {
            repo = new RepositoryHospital();
        }
        // GET: HospitalPlantilla
        public ActionResult VerHospital()
        {
            return View(repo.GetHospital());
        }

        public ActionResult VerPlantilla(int cod_Hospi)
        {
            
            return View(repo.GetPlantilla(cod_Hospi));
        }

        //[HttpPost]
        public ActionResult VerPlantilla(int emp_no, int cod_Hospi)
        {
            repo.DeletePlantilla(emp_no);
            return View(repo.GetPlantilla(cod_Hospi));
        }
    }
}