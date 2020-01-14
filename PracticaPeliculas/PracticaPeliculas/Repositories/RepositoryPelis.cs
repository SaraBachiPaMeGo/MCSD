using PracticaPeliculas.Data;
using PracticaPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Repositories
{
    public class RepositoryPelis
    {
        ContextoPelis context;
        public RepositoryPelis() {
            this.context = new ContextoPelis();
        }

        public List<Genero> GetGeneros()
        {
            var consulta = from datos in context.Generos
                           select datos;
            return consulta.ToList();
        }

        public List<Peli> GetPelis(int genero)
        {
            var consulta = from datos in context.Pelis
                           where datos.IdGenero == genero
                           select datos;
            return consulta.ToList();
        }

        public Peli BuscarPeli(int IdPelicula)
        {
            var dato = from datos in context.Pelis
                       where datos.IdPelicula == IdPelicula
                       select datos;
            return dato.FirstOrDefault();
        }

        public Cliente BuscarCliente(String usuario, int password)
        {
            var consulta = from datos in context.Clientes
                           where datos.IdCliente == password
                           && datos.Nombre == usuario
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Cliente BuscarClienteXX(int idCliente)
        {
            var consulta = from datos in context.Clientes
                           where datos.IdCliente == idCliente
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Pedido> GetPedidos(int IdCliente)
        {
            var consulta = from datos in context.Pedido
                           where datos.IdCliente == IdCliente
                           select datos;
            return consulta.ToList();
        }
        //Sumar 1 en la cantidad de la base de datos
        public void AñadirPedidos(int idCliente, int idPelicula, int cantidad,
            DateTime fecha, int precio)
        {
            Pedido pedi = new Pedido();
            pedi.IdCliente = idCliente;
            pedi.IdPelicula = idPelicula;
            pedi.Cantidad = cantidad;
            pedi.Fecha = fecha;
            pedi.Precio = precio;
            context.SaveChanges();
            
        }
        //Cuando compras -1 en la cantidad de BBDD

    }
}