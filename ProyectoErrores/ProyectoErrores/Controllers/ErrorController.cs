using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoErrores.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Error404()
        {
            //Si sabemos el código de error que 
            //ha provocado al entrar en la página
            //se lo indicaremos en la respuesta de
            //la App --> Response.StatusCode
            Response.StatusCode = (int)HttpStatusCode.NotFound; //404
            ViewBag.Mensaje = "Página no encontrada en el servidor";
            return View();
        }

        //Get: errorgeneral
        public ActionResult ErrorGeneral()
        {
            ViewBag.Mensaje = "Error General";
            return View();
        }
    }
}