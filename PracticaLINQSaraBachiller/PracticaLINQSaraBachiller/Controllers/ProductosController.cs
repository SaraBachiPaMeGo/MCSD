using PracticaLINQSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaLINQSaraBachiller.Controllers
{
    public class ProductosController : Controller
    {
        RepositoryTienda repo;
        public ProductosController() {
            repo = new RepositoryTienda();
        }
        // GET: Productos
        public ActionResult PaginaProductos()
        {
            return View(repo.GetProductos());
        }

        public ActionResult Crear()
        {            
            return View();
        }

        [HttpPost]

        public ActionResult Crear(int idProd, String nombre, String precio, int stock)
        {
            repo.InsertarProducto(idProd, nombre, precio, stock);
            return RedirectToAction("PaginaProductos");
        }

        public ActionResult Modificar(int idProd)
        {
            return View(repo.BuscarProductos(idProd));
        }

        [HttpPost]

        public ActionResult Modificar(int idProd, String nombre, String precio, int stock)
        {
            repo.ModificarProducto(idProd, nombre, precio, stock);
            return RedirectToAction("PaginaProductos");
        }

        public ActionResult Eliminar(int idProd)
        {
            repo.EliminarProducto(idProd);
            return RedirectToAction("PaginaProductos");
        }

        public ActionResult Detalles(int idProd) 
        {
            return View(repo.BuscarProductos(idProd));
        }
    }
}