using PracticaPeliculas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaPeliculas.Controllers
{
    public class HomeController : Controller
    {
        RepositoryPelis repo;
        public HomeController()
        {
            this.repo = new RepositoryPelis();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult _Generos()
        {
            return PartialView(repo.GetGeneros());
        }
    }
}