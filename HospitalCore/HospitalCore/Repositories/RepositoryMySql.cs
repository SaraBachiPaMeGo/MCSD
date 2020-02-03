﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalCore.Data;
using HospitalCore.Models;

namespace HospitalCore.Repositories
{
    public class RepositoryMySql : IRepository
    {
        IContexto context;
        public RepositoryMySql(IContexto context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            return this.context.Hospitales.ToList();
        }

        public void InsertarHospi(Hospital hospi)
        {
            this.context.Hospitales.Add(hospi);
            this.context.SaveChanges();

        }
    }
}
