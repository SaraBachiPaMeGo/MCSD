using ServicioApiDoctor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicioApiDoctor.Data
{
    public class ContextoDoctor : DbContext
    {
        public ContextoDoctor() : base("name=conexionhospital")
        { }
        public DbSet<Doctor> Doctores { get; set; }
    }
}