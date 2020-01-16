using InyeccionHospitales.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionHospitales.Data
{
    public interface IContextoHospital 
    {
        DbSet<Hospital> Hospitales { get; set; }
        int SaveChanges();
    }
}
