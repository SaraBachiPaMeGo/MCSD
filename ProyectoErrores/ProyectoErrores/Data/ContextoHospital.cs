using ProyectoErrores.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoErrores.Data
{
    public class ContextoHospital : DbContext
    {
        public ContextoHospital() : base("name=conexionhospital")
        { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Excepcion> Excepciones { get; set; }
    }
}