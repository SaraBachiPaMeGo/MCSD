using ProyectoMvcEneroAjax.Helpers;
using ProyectoMvcEneroAjax.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMvcEneroAjax.Controllers
{
    public class CifradoController : Controller
    {
        
        RepositoryUsuario repo;

        public CifradoController()
        {
            this.repo = new RepositoryUsuario();
        }
        // GET: Cifrado
        public ActionResult HashSimple()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HashSimple(String texto,String resultado, String accion)
        {
            String cifrados = HelperCifrado.CifrarHashSimple(texto);

            if (accion== "cifrar")
            {
                ViewBag.Cifrado = cifrados;
            } else if(accion=="comparar"){
                if (cifrados == resultado)
                {
                    ViewBag.Mensaje = "El cifrado es igual";
                }
                else {
                    ViewBag.Mensaje = "Son diferentes";
                }
            }
            return View();
        }

        //GET: HASHEFICIENTE
        public ActionResult HashEficiente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HashEficiente(String texto,String resultado, String accion,int iteraciones, String salt)
        {
            String cifrado = HelperCifrado.CifrarHashEficiente(texto, salt, iteraciones);
            if (accion == "cifrar")
            {
                ViewBag.Cifrado = cifrado;
            } else if (accion=="comparar")
            {
                if (cifrado == resultado)
                {
                    ViewBag.Mensaje = "El cifrado es igual";
                }
                else
                {
                    ViewBag.Mensaje = "Son diferentes";
                }
            }
            return View();
        }

        public ActionResult MostrarUsuarios()
        {
            return View(repo.GetUsuarios());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int idUser, String nombre, String usuario, String pass)
        {
            repo.InsertarUser(idUser, nombre, usuario, pass);
            return RedirectToAction("MostrarUsuarios");
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String usuario, String pass)
        {
            repo.ExisteUser( usuario, pass);

            if (repo.ExisteUser(usuario, pass) == null)
            {
                ViewBag.Message = "Usuario/Contraeña incorrectos";
            }
            else {
                ViewBag.Message = "Credenciares correctas " + repo.ExisteUser(usuario, pass).Nombre;
            }
            return View();
        }

        public ActionResult CifrarMensaje(String mensaje, String pass, String resultado,String accion)
        {
            if (accion == "cifrar")
            {
                resultado = HelperCifrado.EncriptarText(mensaje,
                    (new PasswordDeriveBytes(pass, null)).GetBytes(32));
                ViewBag.Resultado2 = resultado;
                
            } else if (accion == "descifrar")
            {
                byte[] textoByte = Encoding.Default.GetBytes(mensaje);
                resultado = HelperCifrado.DesencriptarTexto(textoByte,
                    new PasswordDeriveBytes(pass, null).GetBytes(32));
                ViewBag.Resultado2 = resultado;                

            }     
            return View();       
        }
    }
}