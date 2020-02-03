using AccesoDatosCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatosCore.Data
{
    public class HospitalContext: DbContext, IHospitalContext
    {
        //Inyección de dependencias
        //Lo que necesita es un objeto 
        //contextOptions con los datos
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        { }

        public DbSet<Departamento> Departamentos { get; set; }

    }
}
