using HospitalCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalCore.Data
{
    public class ContextoHospitalSql : DbContext, IContexto
    {
        public ContextoHospitalSql(DbContextOptions<ContextoHospitalSql> options) : base(options)
        { }

        public DbSet<Hospital> Hospitales { get; set; }

        
    }
}
