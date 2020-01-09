using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ContenidoController : Controller
    {
        // GET: YouTube
        public ActionResult Youtube()
        {
            return View();
        }

        //POST : Youtube
        [HttpPost]
        public ActionResult YouTube(String video)
        {
            //https://www.youtube.com/watch?v=Bs8a3lESo3s

            int posIdVideo = video.LastIndexOf("v=");
            //Queremos coger los caracteres mas dos del v= 
            String idVideo = video.Substring(posIdVideo + 2);

            String contenido = "<iframe width='560' height='315' src='https://www.youtube.com/embed/" +
             idVideo +"' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"; 

            return Content(contenido);
        }

        public ActionResult JavaScript() 
        {
            //Hay que hacer dos ActionResult uno que 
            //devuelva la vista y otro el script
            //Sino, sólo devolverá texto
            //SE UTILIZA JQUERY

            //String js = "function cambiarImg(){";
            //js += " document.getElementById('img')"
            //    + ".src ='anochecer.jpg';"
            //    + "}";

            //return JavaScript(js);
            return View();
        }

        public ActionResult EjecutarJs() 
        {
            //URL CONTENT NOS DEVULVE LA URL ABSOLUTA DE X
            String urlImg = Url.Content("~/Assets/anochecer.jpg");
            String script =
                "$('#img').attr('src','" + urlImg + "');";
            return JavaScript(script);
        }
        public ActionResult GetFile() 
        {
            //image/jpeg
            String url = Url.Content("~/Assets/anochecer.jpg");
            return File(url, "image/jpeg");
        }

        public ActionResult ContenidoJson()
        {
            Persona p = new Persona();
            p.Nombre = "Sarai";
            p.Apellidos = "García";
            p.Edad = 42;
            p.Email = "fff@gmail.com";
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}