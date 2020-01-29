using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamenMVCSaraBachiller.Data;
using ExamenMVCSaraBachiller.Models;

namespace ExamenMVCSaraBachiller.Repositories
{
    public class RepositoryLibros: IRepository
    {
        IContexto context;
        public RepositoryLibros(IContexto context)
        {
            this.context = context;
        }

        public List<Genero> GetGeneros()
        {
            return this.context.Generos.ToList();
        }

        public List<Libro> GetLibros()
        {
            return this.context.Libros.ToList();
        }

        public Libro BuscarLibro(int idLibro)
        {
            return this.context.Libros.SingleOrDefault(z => z.IdLibro == idLibro);
        }

        public List<Libro> GetLibrosGenero(int idGenero)
        {
            var consulta = from datos in context.Libros
                           where datos.IdGenero == idGenero
                           select datos;
            return consulta.ToList();
        }

        public List<Pedido> GetPedidos()
        {
            return this.context.Pedidos.ToList();
        }

        public List<Usuario> GetUsuarios()
        {
            return this.context.
                Usuarios.ToList();
        }

        public void InsertarPedidos(List<Libro> libros, int IdUsuario, List<int> cantidades)
        {
            Pedido pedi = new Pedido();

            int IdPedido = this.context.Pedidos.Max(z => z.IdPedido) +1;
            pedi.IdPedido = IdPedido;

            int IdFactura = this.context.Pedidos.Max(z => z.IdFactura) + 1;
            pedi.IdFactura = IdFactura;

            DateTime Fecha = DateTime.Now;
            pedi.Fecha = Fecha;

            pedi.IdUsuario = IdUsuario;
            

            foreach (int cantidad in cantidades)
            {
                 pedi.Cantidad = cantidad; 
            }

            foreach (Libro li in libros)
            {
                pedi.IdLibro = li.IdLibro;
            }

            this.context.Pedidos.Add(pedi);
            this.context.SaveChanges();
        }

        public Usuario BuscarUsuario(string email, string pass)
        {
            return this.context.Usuarios.SingleOrDefault(z => z.Email == email && z.Pass ==pass);
        }

        public Usuario BuscarUsuarioId(int id)
        {
            return this.context.Usuarios.SingleOrDefault(z => z.IdUsuario == id);
        }

        public List<VistaPedidos> GetVistaPedidos()
        {
            return this.context.
                VistaPedidos.ToList();
        }

        
    }


}