using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ValidacionCore.Filters;
using ValidacionCore.Models;
using ValidacionCore.Repositories;

namespace ValidacionCore.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmp repo; 
        public EmpleadosController(RepositoryEmp repo)
        {
            this.repo = repo;
        }

        [Autenti]
        public IActionResult Index()
        {
            return View(repo.GetEmpleados());
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(String nombre, int id)
        {
            Empleados emp = repo.BuscarEmp(nombre, id);

            if (emp != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    ClaimTypes.Name, ClaimTypes.Role
                    );
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, id.ToString())); //ID
                identity.AddClaim(new Claim(ClaimTypes.Name, nombre));
                identity.AddClaim(new Claim(ClaimTypes.Role, emp.Oficio));


                //Usuario principal 
                ClaimsPrincipal empP = new ClaimsPrincipal(identity);

                //Almacenamos la cookie 
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    empP,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(14)
                    });

                String action = TempData["action"].ToString();
                String controller = TempData["controller"].ToString();

                return RedirectToAction(action,controller);
            }
            else {
                ViewData["MENSAJE"] = "Usuario/Contraseña incorrectos";
                return View();
            }
        }
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme
                );
            return RedirectToAction("Index");
        }
        [Autenti]
        public IActionResult Perfil()
        {
            return View(repo.GetEmpleados());
        }

        [Autenti]
        public IActionResult Subor()
        {
            ClaimsPrincipal empP = HttpContext.User; 
            var id = int.Parse(empP.FindFirst(ClaimTypes.NameIdentifier).Value.ToString());     
            //var id = int.Parse(empP.FindFirstValue..ToString());

            return View(repo.BuscarSubord(id));
        }
    }
}