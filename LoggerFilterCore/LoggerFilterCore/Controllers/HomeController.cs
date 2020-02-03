using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoggerFilterCore.Models;
using Microsoft.Extensions.Logging;
using LoggerFilterCore.Filters;

namespace LoggerFilterCore.Controllers
{
    public class HomeController : Controller
    {
        ILogger logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        //[MensajesFilter]
        //ServiceFilter -->Se encarga de inicializar atributos
        //filter que estan con Inyección de dependencias
        //El tipo de filtro que va a crear
        [ServiceFilter(typeof(MensajesFilter))]
        public IActionResult Index()
        {
            logger.LogInformation("------------------------------------- ESTOY EN HOME ------------------------------------");
            return View();
        }

        public IActionResult About()
        {
            logger.LogInformation("-------------------------------------ESTOY EN ABOUT------------------------------------");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
