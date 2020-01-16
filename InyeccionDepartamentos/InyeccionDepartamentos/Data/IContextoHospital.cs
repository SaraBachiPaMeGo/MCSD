using InyeccionDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDepartamentos.Data
{
    public interface IContextoHospital
    {
        DbSet<Departamento> Departamentos { get; set; }
        int SaveChanges();
    }
}
