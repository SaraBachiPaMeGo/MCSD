using InyeccionDepartamentos.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionDepartamentos.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContextoHospitalMYSQL : DbContext, IContextoHospital
    {
        public ContextoHospitalMYSQL() : base("name=cadenahospitalmysql")
        { }

        public DbSet<Departamento> Departamentos { get; set; }
        
        public void SaveChanges()
        {
        }
    }
}