using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesoDatosCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatosCore.Data
{
    public class HospitalContextMySql : DbContext,IHospitalContext
    {
        public HospitalContextMySql(DbContextOptions<HospitalContextMySql>options) :base(options)
        { }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
