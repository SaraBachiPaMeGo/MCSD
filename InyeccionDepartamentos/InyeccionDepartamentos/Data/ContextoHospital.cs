using InyeccionDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionDepartamentos.Data
{
    public class ContextoHospital : DbContext, IContextoHospital
    {
        public ContextoHospital() : base("name=conexionhospital")
        { }

        public DbSet<Departamento> Departamentos { get; set; }

        public void SaveChanges()
        {
        }
    }
}