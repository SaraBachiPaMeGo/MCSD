using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {

            return View();
        }

        //POST: Index
        [HttpPost]
        public ActionResult Index(Persona person)
        {
            //SI LOS DATOS DE LAS VALIDACIONES SON
            //CORRECTOS, LO ENVIAREMOS A OTRA VISTA
            if (ModelState.IsValid == true)
            {
                //INSERTAR, MODIFICAR O LO QUE SEA
                return View("DatosCorrectos");
            }
            //SI NO ES VALIDO, LO MANTENEMOS EN LA VISTA
            return View();
        }

        public ActionResult DatosCorrectos()
        {
            return View();
        }
    }
}