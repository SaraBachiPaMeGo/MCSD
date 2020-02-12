using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MenuViewComponents.Models;
using MenuViewComponents.Repositories;

namespace MenuViewComponents.Controllers
{
    public class HomeController : Controller
    {

        RepositoryDept repo;

        public HomeController(RepositoryDept repo)
        {
            this.repo = repo;
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

        public IActionResult Prueba()
        {
            return View(repo.GetDepartamentos());
        }

        public IActionResult Detalles(int idDept)
        {
            return View(repo.BuscarDept(idDept));
        }
    }
}
