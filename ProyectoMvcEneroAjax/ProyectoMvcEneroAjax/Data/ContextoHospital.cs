using ProyectoMvcEneroAjax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Data
{
    public class ContextoHospital : DbContext
    {
        public ContextoHospital() : base("name=conexionhospital")
        { }
        public DbSet<Plantilla> Plantillas { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}