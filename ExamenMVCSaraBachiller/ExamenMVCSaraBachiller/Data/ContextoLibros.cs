using ExamenMVCSaraBachiller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Data
{
    public class ContextoLibros : DbContext, IContexto
    {
        public ContextoLibros() : base("name=conexiontienda") { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<VistaPedidos> VistaPedidos { get; set; }
    }
}