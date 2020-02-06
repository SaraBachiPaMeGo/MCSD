using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerCore.MethodExtensions;
using PrimerCore.Model;
using PrimerCore.Models;

namespace PrimerCore.Controllers
{
    public class SesionController : Controller
    {
        public IActionResult SesionSimple(String accion)
        {
            if (accion == "guardar" || accion == null)
            {
                //La sessión se almacena dentro de HttpContext
                //HtpContext.Session
                HttpContext.Session.SetString("App","Net Core Session");
                HttpContext.Session.SetString("Nombre", "Programador");
                HttpContext.Session.SetInt32("Edad", 22);
                ViewData["MENSAJE"] = "Datos almacenados "
                    + DateTime.Now.ToLongTimeString();
            } else if (accion == "mostrar")
            {
                ViewData["APP"] = HttpContext.Session.GetString("App");
                ViewData["NOMBRE"] = HttpContext.Session.GetString("Nombre");
                ViewData["EDAD"] = HttpContext.Session.GetInt32("Edad");
                ViewData["MENSAJE"] = "Mostrando datos almacenados"
                    + DateTime.Now.ToLongTimeString();
            }
            return View();
        }

        public IActionResult SesionObjeto(String accion)
        {
            if (accion == "guardar" || accion == null)
            {
                Informacion info = new Informacion();
                info.Aplicacion = "Net Core Session";
                info.Nombre = "Programador experto";
                info.Edad = 29;

                HttpContext.Session.SetObjeto("INFO",info);

                Coche car = new Coche();
                car.Marca = "Ford";
                car.Modelo = "Mustang";
                car.Velocidad = 125;
                car.Imagen = "Coche1.jpg";

                HttpContext.Session.SetObjeto("COCHE", car);

                ViewData["MENSAJE"] = "Datos guardados "
                    + DateTime.Now.ToLongTimeString();
            }
            else if (accion == "mostrar")
            {
                Informacion info = HttpContext.Session.GetObjecto<Informacion>("INFO");
                Coche car = HttpContext.Session.GetObjecto<Coche>("COCHE");

                ViewData["APP"] = info.Aplicacion;
                ViewData["NOMBRE"] = info.Nombre;
                ViewData["EDAD"] = info.Edad;

                ViewData["MENSAJE"] = "Mostrando datos almacenados"
                    + DateTime.Now.ToLongTimeString();

                ViewData["MARCA"] = car.Marca;
                ViewData["MODELO"] = car.Modelo;
                ViewData["VELOCIDAD"] = car.Velocidad;
                ViewData["IMAGEN"] = car.Imagen;
            }
            return View();
        }
    }
}