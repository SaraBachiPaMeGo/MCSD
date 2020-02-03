using HospitalCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalCore.Repositories
{
    public interface IRepository
    {
        List<Hospital> GetHospitales();
        void InsertarHospi(Hospital hospi);
    }
}
