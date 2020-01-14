using PracticaPeliculas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Data
{
    public class ContextoPelis : DbContext
    {
        public ContextoPelis() : base("name=conexionpelis")
            {}
        public DbSet <Cliente> Clientes { get;set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Peli> Pelis { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}