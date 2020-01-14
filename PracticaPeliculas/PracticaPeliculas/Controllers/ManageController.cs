using PracticaPeliculas.Authorization;
using PracticaPeliculas.Models;
using PracticaPeliculas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PracticaPeliculas.Controllers
{
    public class ManageController : Controller
    {
        RepositoryPelis repo;
        public ManageController()
        {
            this.repo = new RepositoryPelis();
        }
        // GET: Manage
        public ActionResult Peliculas(String genero)
        {
            return View(repo.GetPelis(int.Parse(genero)));
        }

        public ActionResult Details(int idPeli) 
        {
            return View(repo.BuscarPeli(idPeli));
        }

        public ActionResult LogIn() 
        {
            return View();
        }

        [HttpPost]

        public ActionResult LogIn(String usuario, String password)
        {
            Cliente cli = repo.BuscarCliente(usuario,int.Parse(password));

            if(cli!= null)
            {
                //Creo el ticket
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1,cli.IdCliente.ToString(),DateTime.Now, 
                    DateTime.Now.AddMinutes(10),true,"");
                //Encryto el ticket
                String dato = FormsAuthentication.Encrypt(ticket);
                //Creo la cookie
                HttpCookie cookie = new HttpCookie("COOKIE",dato);
                //Añado la cookie
                Response.Cookies.Add(cookie);
                return RedirectToAction("Perfil");//Tiene que se dinámico para comprar
            }
            else
            {
                ViewBag.Mensaje = "Usuario/ contraseña incorrecto";
                return View();
            }
        }

        [Autorizacion]
        public ActionResult Comprar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Comprar(String idPeli, String idCliente)
        {
            return View();
        }

        [Autorizacion]
        public ActionResult Perfil()
        {
            return View();
        }
    }
}