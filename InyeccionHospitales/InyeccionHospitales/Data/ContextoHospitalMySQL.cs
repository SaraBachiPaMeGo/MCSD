using InyeccionHospitales.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionHospitales.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContextoHospitalMySQL : DbContext, IContextoHospital
    {
        public ContextoHospitalMySQL() : base("name= cadenahospitalmysql")
        { }
        public DbSet<Hospital> Hospitales { get; set; }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
    
}