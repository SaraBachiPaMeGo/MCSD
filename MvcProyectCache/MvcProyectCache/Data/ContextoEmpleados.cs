using MvcProyectCache.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProyectCache.Data
{
    public class ContextoEmpleados : DbContext
    {
        public ContextoEmpleados() : base("conexiontajamar")
        { 
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ContextoEmpleados>(null); //No queremos inicializadores
            //Si cambiamos algo, añadimos una nueva propiedad al modelo o cosas así lo almacena 
            //En la memoria, por lo que tenemos que hacer esto
            base.OnModelCreating(modelBuilder);
        }
    }
}