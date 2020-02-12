using MenuViewComponents.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuViewComponents.Data
{
    public class ContextoHospi : DbContext
    {
        public ContextoHospi(DbContextOptions<ContextoHospi> options):base(options) { }
        
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
