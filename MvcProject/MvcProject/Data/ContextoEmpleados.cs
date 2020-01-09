using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProject.Data
{
    public class ContextoEmpleados: DbContext
    {
        public ContextoEmpleados()
            :base("conexiontajamar")
        {}

        public DbSet<Empleado> Empleados { get; set; }

        protected override void 
            OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ContextoEmpleados>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}