using MvcProyectCache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProyectCache.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        //POST:Index
        [HttpPost]
        public ActionResult Index(Persona person) {
            //Si los datos de las validaciones son correctos
            //Enviaremos al usuario a otra vista
            if (ModelState.IsValid == true)
            {
                //Insertar,Modificar o lo que sea
                return View("DatosCorrectos");
            }
            //Si no es válido lo mantenemos en la vista
            return View();
        }

        public ActionResult DatosCorrectos() 
        {
            return View();
        }

    }
}