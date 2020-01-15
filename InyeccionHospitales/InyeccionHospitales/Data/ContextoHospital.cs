using InyeccionHospitales.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionHospitales.Data
{
    public class ContextoHospital : DbContext
    {
        public ContextoHospital() :base("name= cadenahospitalsql")
        { }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}