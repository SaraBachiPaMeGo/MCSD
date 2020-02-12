using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionCore.Models;

namespace ValidacionCore.Data
{
    public class ContextoHospital : DbContext
    {
        public ContextoHospital(DbContextOptions<ContextoHospital>options) : base(options)
        { }
        public DbSet<Empleados> Empleados { get; set; }
    }
}
