using InyeccionHospitales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionHospitales.Repositories
{
    public interface IRepositoryHospital
    {
        List<Hospital> GetHospitales();
        void InsertarHospitales(int id, 
            string nombre, string direccion,
            string tlf, int camas);
    }
}
