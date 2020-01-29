using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;

namespace PrimerCore.Controllers
{
    public class CochesController : Controller
    {
        ICoche car;

        public CochesController(ICoche car)
        {
            this.car = car;
        }

        public IActionResult Index()
        {
            return View(this.car);
        }

        [HttpPost]
        public IActionResult Index(String accion)
        {
            if (accion == "frenar")
            {
                car.Frenar();
            }
            else if(accion=="acelerar"){
                car.Acelerar();
            }
            return View(this.car);
        }
    }
}