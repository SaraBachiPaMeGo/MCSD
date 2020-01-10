using SeguridadDoctores.Authorization;
using SeguridadDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SeguridadDoctores.Controllers
{
    public class ManageController : Controller
    {
        RespositoryDoctor repo;

        public ManageController() 
        {
            this.repo = new RespositoryDoctor();
        }
        // GET: Manage
        public ActionResult Doctores()
        {            
            return View(repo.GetDoctores());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(String usuario, String password, int numero)
        {
            //repo.BuscarDoctor();
            if (repo.BuscarDoctor(usuario,numero)!=null)
            {
                //Creo un ticket
                FormsAuthenticationTicket ticket =
                    new FormsAuthenticationTicket(1,usuario,DateTime.Now , DateTime.Now.AddMinutes(15),
                    true,"DOCTOR");
                //Encripto el ticket
                String dato = FormsAuthentication.Encrypt(ticket);
                //Creo una cookie
                HttpCookie cookie = new HttpCookie("TICKETDOCTOR",dato);
                //Añado la cookie en el response
                Response.Cookies.Add(cookie);
                return RedirectToAction("Modificar");
            }
            else
            {
                ViewBag.Mensaje = "Ups! Hay algún dato erróneo.";
                return View();
            }
            
        }
        [Autorizacion]
        public ActionResult Modificar() 
        {
            return View();
        }
    }
}