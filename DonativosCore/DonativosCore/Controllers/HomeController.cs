using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DonativosCore.Models;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights;

namespace DonativosCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Donativos()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Donativos(String nombre, int cantidad)
        {
            ViewData["MENSAJE"] = "Su donativo de " + cantidad + "€ ha sido guardado. Gracias " + nombre;

            //Enviar trazas a telemetría de Azure
            Trace.TraceInformation(nombre + "" + cantidad+"€");

            //Creamos una métrica que permitirá poder evaluar
            //cantidades
            MetricTelemetry metrica = new MetricTelemetry();
            metrica.Name = "Donativos";
            metrica.Sum = cantidad;

            //La métrica va dentro de un cliente
            TelemetryClient cliente = new TelemetryClient();

            //Incluímos un evento
            cliente.TrackEvent("Acciones donativos");
            cliente.TrackMetric(metrica);

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
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
