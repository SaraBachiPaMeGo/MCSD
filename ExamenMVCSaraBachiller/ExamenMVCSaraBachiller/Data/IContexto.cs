using ExamenMVCSaraBachiller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMVCSaraBachiller.Data
{
    public interface IContexto
    {
         DbSet<Pedido> Pedidos { get; set; }
         DbSet<Usuario> Usuarios { get; set; }

         DbSet<Libro> Libros { get; set; }
         DbSet<Genero> Generos { get; set; }

        DbSet<VistaPedidos> VistaPedidos { get; set; }
        int SaveChanges();
    }
}
