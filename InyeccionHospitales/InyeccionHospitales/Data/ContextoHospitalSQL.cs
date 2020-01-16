using InyeccionHospitales.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionHospitales.Data
{
    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContextoHospitalSQL: DbContext, IContextoHospital
    {
        public ContextoHospitalSQL() :base("name= cadenahospitalsql")
        { }
        public DbSet<Hospital> Hospitales { get; set; }

    }
}