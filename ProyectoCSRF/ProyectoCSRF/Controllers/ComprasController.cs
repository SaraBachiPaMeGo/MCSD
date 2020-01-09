using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCSRF.Controllers
{
    public class ComprasController : Controller
    {
        // GET: Compras

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String usuario, String pass)
        {
            if (usuario.ToLower() == "admin" && pass.ToLower() == "admin")
            {
                //Entra en la app
                Session["USUARIO"] = usuario;                
                return RedirectToAction("Pedidos");
            }
            else 
            {
                ViewBag.Mensaje = "Usuario/Password incorrectos";
            }
            return View();
        }
        public ActionResult SinAcceso()
        {
            return View();
        }

        public ActionResult Pedidos()
        {
            if (Session["USUARIO"] == null)
            {
                return View("SinAcceso");
            }
            return View();
        }

        //Post: Pedidos
        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult Pedidos(String [] producto, String direccion)
        {
            if (Session["USUARIO"] == null)
            {
                return View("SinAcceso");
            }
            //TempData se destruye en el momento de leerlo, se utiliza para
            //mandar informacion de un action a otro action
            TempData["DIRECCION"] = direccion;
            TempData["PRODUCTOS"] = producto;
            //De esta manera vamos a enviar a carrito estos datos
            return RedirectToAction("Carrito");
        }

        public ActionResult Carrito()
        {
            ViewBag.Direccion = TempData["DIRECCION"];//Se destruye lo que haya en su interior
            String[] productos = TempData["PRODUCTOS"] as String[];
            return View(productos);
        }
    }
}