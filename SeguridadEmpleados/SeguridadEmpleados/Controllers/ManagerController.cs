using SeguridadEmpleados.Authorization;
using SeguridadEmpleados.Models;
using SeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SeguridadEmpleados.Controllers
{
    public class ManagerController : Controller
    {
        RepositoryEmpleados repo;
        public ManagerController()
        { 
            this.repo = new RepositoryEmpleados();
        }
        // GET: Manager
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String usuario, int password)
        {
            Empleados emp = repo.ExisteEmpleado(usuario, password)
                ;
            if (repo.ExisteEmpleado(usuario, password)!=null)
            {
                //Creo un ticket
                FormsAuthenticationTicket ticket = 
                    new FormsAuthenticationTicket (1, emp.Emp_no.ToString(), 
                    DateTime.Now, DateTime.Now.AddMinutes(10),true, emp.Oficio);
                //Encripto el ticket
                String datos = FormsAuthentication.Encrypt(ticket);
                //creo una cookie
                HttpCookie cookie = new HttpCookie("EMPLEADO",datos);
                //Añado la cookie al response
                Response.Cookies.Add(cookie);

                //Debemos recuperar el action y el controller para que la navegación
                //en la seguridad sea dinámica
                String action = TempData["ACTION"].ToString();
                String controller = TempData["CONTROLLER"].ToString();

                return RedirectToAction(action, controller);
            }
            else
            {
                ViewBag.Mensaje = "Usuario o contraseña incorrectos";
                return View();
            }
            
        }
        //GET
        public ActionResult SinAcceso()
        {
            return View();
        }

        [Autorizacion]
        //GET
        public ActionResult ModificarEmpleado(int empno) 
        {
            return View(repo.BuscarEmp(empno));
        }
        [HttpPost]
        public ActionResult ModificarEmpleado(Empleados emp)
        {
            repo.ModificarEmpleado(emp.Emp_no, emp.Nombre, emp.Oficio, emp.Salario);
            return RedirectToAction("Index","Empleado");
        }

        public ActionResult CerrarSesion()
        {
            //Limpiamos el usuario actual de sesión
            HttpContext.User = null;

            //Cerramos la sesión con el método singout
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["EMPLEADO"];

            //Hacemos que la cookie expire
            cookie.Expires = DateTime.Now.AddMinutes(-30);

            //Almacenamos la cookie con la nueva fecha
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index","Home");
        }
    }
}