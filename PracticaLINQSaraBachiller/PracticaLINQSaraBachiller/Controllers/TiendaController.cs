using PracticaLINQSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaLINQSaraBachiller.Controllers
{
    public class TiendaController : Controller
    {
        RepositoryTienda repo;

        public TiendaController() {
            repo = new RepositoryTienda();
        }

        // GET: Tienda
        public ActionResult PaginaClientes()
        {
            return View(repo.GetClientes()) ;
        }

        

        
    }
}