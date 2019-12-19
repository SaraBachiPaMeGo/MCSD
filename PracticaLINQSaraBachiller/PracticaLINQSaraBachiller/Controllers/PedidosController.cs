using PracticaLINQSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaLINQSaraBachiller.Controllers
{
    public class PedidosController : Controller
    {
        RepositoryTienda repo;

        public PedidosController() {
            repo = new RepositoryTienda();
        }
        // GET: Pedidos
        public ActionResult PaginaPedidos(String idCli)
        {
            return View(repo.GetPedidos(idCli));
        }
    }
}