using AccesoDatosCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatosCore.Data
{
    public interface IHospitalContext
    {
        DbSet <Departamento> Departamentos { get; set; }
    }
}
