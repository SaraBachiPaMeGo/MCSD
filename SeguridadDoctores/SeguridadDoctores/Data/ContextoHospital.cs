using SeguridadDoctores.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeguridadDoctores.Data
{
    public class ContextoHospital : DbContext
    {
        public ContextoHospital() : base("name=conexionhospital")
        { }
        public DbSet<Doctor> Doctores {get;set;}
         
    }
}