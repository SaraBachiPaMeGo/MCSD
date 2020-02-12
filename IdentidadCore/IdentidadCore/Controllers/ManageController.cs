using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace IdentidadCore.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(String usuario, String password)
        {
            //Para guardar una cookie --> Async
            if (usuario.ToUpper() == "ADMIN" && password.ToUpper() == "ADMIN")
            {
                //Almacenamos el user y la cookie
                //Un usuario siempre será un Principal
                //compuesto por una identidad
                //Creamos una identidad
                //Valida el perfil de la cookie
                ClaimsIdentity identity = new ClaimsIdentity(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    ClaimTypes.Name, ClaimTypes.Role
                    );

                //Podemos agregar mas características a la identidad
                //utilizando los claims
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario));
                identity.AddClaim(new Claim(ClaimTypes.Name, usuario));
                identity.AddClaim(new Claim("EMAIL", "user@gmail.com"));

                //Creamos un usuario principal con la identidad
                ClaimsPrincipal userP = new ClaimsPrincipal(identity);

                //Debemos almacenar la cookie, pero no cualquiera
                //Tenemos que guardarla como validación --> Asyncrona
                await HttpContext.SignInAsync(
                    //Esquema de cookie
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    //Usuario Principal
                    userP,
                    //Personalizar cuanto tiempo va a estar
                    new AuthenticationProperties { 
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(14)
                    }
                    );
                return RedirectToAction("Perfil","Usuario");
            }
            else 
            {
                ViewData["MENSAJE"] = "Usuario/contraseña incorrectos";
                return View();
            }
        }
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(
                //El esquema que estamos utilizando
                CookieAuthenticationDefaults.AuthenticationScheme
                );
            return RedirectToAction("Index");

            //dentro de la cookie un xml encriptados
            //Un schema es un XSD, valida que el formato del 
            //XML sea como se ha creado originalmente
            //Para evitar la suplantación 
        }
    }
}