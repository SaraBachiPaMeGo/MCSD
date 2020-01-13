using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeguridadEmpleados.Data
{
    public class ContextoHospital: DbContext
    {
        public ContextoHospital() : base("name=conexionhospital")
        {}
       public DbSet <Empleados> Empleados { get; set; }
    }
}