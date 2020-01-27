using ServicioApiCoches.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicioApiCoches.Data
{
    public class CochesContext : DbContext
    {
        public CochesContext() : base("name=conexionhospital") { }
        public DbSet<Coche> Coches { get; set; }
    }
}