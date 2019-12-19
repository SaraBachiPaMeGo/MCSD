using PracticaLINQSaraBachiller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaLINQSaraBachiller.Repositories
{
//    CREATE VIEW VISTAPEDIDOS
//AS

//     SELECT isnull(ROW_NUMBER() over (ORDER BY CODIGOCLIENTE),0) as Posicion, dbo.Pedidos.CodigoCliente, dbo.Productos.Nombre AS NombreProducto, dbo.Productos.Precio, dbo.Productos.Precio* dbo.Pedidos.Unidades AS PrecioTotal, dbo.Pedidos.Unidades AS Cantidad, dbo.Pedidos.FechaPedido
//FROM dbo.Productos
//INNER JOIN
//dbo.Pedidos
//ON dbo.Productos.IdProducto = dbo.Pedidos.IdProducto
//GO
    public class RepositoryTienda
    {
        ContextoTienda context;
        public RepositoryTienda() 
        {
            context = new ContextoTienda();
        }

        public List<Clientes> GetClientes() {
            var consulta = from datos in context.Clientes
                           select datos;
            return consulta.ToList();
        }

        public List<VISTAPEDIDOS> GetPedidos(String idCli)
        {
            var consulta = (from datos in context.VISTAPEDIDOS
                            select datos).Where(z => z.CodigoCliente == idCli);
            
            return consulta.ToList();
        }

        public List<Productos> GetProductos()
        {
            var consulta = from datos in context.Productos
                           select datos;
            return consulta.ToList();
        }

        public Productos BuscarProductos(int idProd) {
            var consulta = from dato in context.Productos
                           select dato;
            Productos pro = consulta.SingleOrDefault(z => z.IdProducto == idProd);
            return pro;
        }

        public void InsertarProducto(int idProd, String nombre, String precio, int stock) {
            Productos prod = new Productos();

            prod.IdProducto = idProd;
            prod.Nombre = nombre;
            prod.Precio = precio;
            prod.Stock = stock;

            context.Productos.Add(prod);
            context.SaveChanges();
        }

        public void ModificarProducto(int idProd, String nombre, String precio, int stock)
        {
            Productos prod = this.BuscarProductos(idProd);

            prod.Nombre = nombre;
            prod.Precio = precio;
            prod.Stock = stock;

            context.SaveChanges();
        }

        public void EliminarProducto(int idProd)
        {
            Productos prod = this.BuscarProductos(idProd);
            context.Productos.Remove(prod);
            context.SaveChanges();
        }
    }
}