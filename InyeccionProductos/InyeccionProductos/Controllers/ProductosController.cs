using InyeccionProductos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionProductos.Controllers
{
    public class ProductosController : Controller
    {
        IRepositoryProductos repo;

        public ProductosController(IRepositoryProductos repo) //INYECCIÓN
        {
            this.repo = repo;
        }
        //Nugget para MVC en core no 
        // GET: Productos
        public ActionResult Index()
        {
            return View(this.repo.GetProductos());
        }
    }
}