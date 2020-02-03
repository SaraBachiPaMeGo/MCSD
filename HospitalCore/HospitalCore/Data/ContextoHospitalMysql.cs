using HospitalCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalCore.Data
{
    public class ContextoHospitalMysql: DbContext, IContexto
    {
        public ContextoHospitalMysql(DbContextOptions<ContextoHospitalMysql> options) : base(options)
        { }

        public DbSet<Hospital> Hospitales { get ; set ; }
    }
}
