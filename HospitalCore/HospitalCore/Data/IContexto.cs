using HospitalCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalCore.Data
{
    public interface IContexto
    {
        DbSet<Hospital> Hospitales { get; set; }
        int SaveChanges();
    }
}
