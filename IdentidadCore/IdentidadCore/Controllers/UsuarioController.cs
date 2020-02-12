using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentidadCore.Filters;
using Microsoft.AspNetCore.Mvc;

namespace IdentidadCore.Controllers
{
    public class UsuarioController : Controller
    {
        [Autorizacion]
        public IActionResult Perfil()
        {
            return View();
        }
    }
}