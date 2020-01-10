using SegirodadPersonalizada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SegirodadPersonalizada.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String usuario, String password)
        {
            ValidarUsuarios v = new ValidarUsuarios();
            if (v.ExisteUsuario(usuario, password))
            {
                //Existe
                String role = v.Role;
                //Necesitamos el TICKET para la cookie de Seguridad
                //Necesitamnos: la version (siempre va a ser la 1),
                // ususario, inicio, duración, 
                // Si queremos que la cookie sea permsistente, datos
                // datos de usuario (Información para el programador,
                // se suele guardar normalmente el rol del usuario) 
                // NO ES RELEVANTE PARA LA COOKIE
                // y ruta (path)
                FormsAuthenticationTicket ticket =
                    new FormsAuthenticationTicket
                    (1, usuario, DateTime.Now, DateTime.Now.AddMinutes(10),true,role);

                //Debemos cifrar el ticket, nos devuelve un string
                String datos = FormsAuthentication.Encrypt(ticket);

                //Crear una cookie con el nombre que deseemos
                //El nombre es importante porque necesitamos recuperar
                //el ticket para crear el usuario en la sesión a 
                //partir de ese ticket
                //httpCookie -->Crear una cookie. Le daremos un nombre y un valor
                
                HttpCookie cookie = new HttpCookie("USERTICKET", datos);
                //Se almacenan en Response
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Administracion");
            }
            else 
            {
                ViewBag.Mensaje = "Usuario/Password incorrectos";
                return View();
            }
            
        }

        public ActionResult ErrorAcceso()
        {
            return View();
        }
    }
}