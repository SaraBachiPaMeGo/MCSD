using ExamenMVCSaraBachiller.Autorize;
using ExamenMVCSaraBachiller.Models;
using ExamenMVCSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ExamenMVCSaraBachiller.Controllers
{
    public class LibrosController : Controller
    {
        IRepository repo;

        public LibrosController(IRepository repo)
        {
               this.repo = repo;
        }
        // GET: Libros
        public ActionResult Index()
        {
            ViewBag.Generos = repo.GetGeneros();
            return View();
        }
        //LibrosGenero
        public ActionResult Generos()
        {
            return View(repo.GetGeneros());
        }
       
        public ActionResult LibrosGenero(int idGenero)
        {
            return View(repo.GetLibrosGenero(idGenero));
        }

        public ActionResult AllLibros()
        {
            return View(repo.GetLibros());
        }

        public ActionResult Details(int id)
        {
            return View(repo.BuscarLibro(id));
        }
        
        public ActionResult Comprar(int id)
        {
            Libro libro = repo.BuscarLibro(id);

            if (Session["LibrosComprados"] != null)
            {
                List<Libro> listaLibros = (List<Libro>) Session["LibrosComprados"];
                listaLibros.Add(libro);
            }
            else
            {
                List<Libro> listaLibros = new List<Libro>();                
                listaLibros.Add(libro);

                Session["LibrosComprados"] = listaLibros;
            }

            return RedirectToAction("AllLibros");
        }

        [Autorize]
        public ActionResult FinalizarCompra()
        {
            //Sesion de libros
            //Sesion de usuario
            int cantidad =(int) Session["CANTIDAD"];
             
            UsuarioPrincipal user = (UsuarioPrincipal)HttpContext.User;
            List<Libro> Lista = (List<Libro>)Session["LibrosComprados"];

            List<int> cantidades = (List<int>)Session["CANTIDADES"];

            if (Session["CANTIDADES"] == null)
            {
                cantidades = new List<int>();
                cantidades.Add(cantidad);
                repo.InsertarPedidos(Lista, user.IdUsuario ,cantidades);
            }
            else
            {
                cantidades.Add(cantidad);
                repo.InsertarPedidos(Lista, user.IdUsuario, cantidades);
            }

            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(String email, String pass)
        {
            Usuario user = repo.BuscarUsuario(email, pass);
            if (user!=null)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,user.IdUsuario.ToString(),
                    DateTime.Now, DateTime.Now.AddMinutes(10),
                    true, "");
                String dato = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie("COOKIE", dato);
                Response.Cookies.Add(cookie);
                ViewBag.M = "Ya estás validado";
            }
            else {
                ViewBag.MensajeError = "Usuario/Contraseña incorrectos";
            }            

            return View();
        }

        public ActionResult CerrarSesion()
        {
            HttpContext.User = null;
            FormsAuthentication.SignOut();

            HttpCookie cooki = Request.Cookies["COOKIE"];
            cooki.Expires = DateTime.Now.AddMinutes(-30);

            Response.Cookies.Add(cooki);
            ViewBag.c = "Sesión cerrada";
            return RedirectToAction("LogIn");
        }

        //SinAcceso
        public ActionResult SinAcceso()
        {
            return View();
        }

        public ActionResult Carrito()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Carrito(int cantidad)
        {
            Session["CANTIDAD"] = cantidad;
            return RedirectToAction("FinalizarCompra");
        }
        [Authorize]
        public ActionResult Perfil()
        {
            return View();
        }
    }
}