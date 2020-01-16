using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InyeccionHospitales.Data;
using InyeccionHospitales.Models;

namespace InyeccionHospitales.Repositories
{
    public class RepositoryHospitalSQL : IRepositoryHospital
    {
        IContextoHospital context;
        public RepositoryHospitalSQL(IContextoHospital context)//Inyección
        {
            this.context = context;   
        }
        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in context.Hospitales
                           select datos;

            return consulta.ToList();
        }

        public void InsertarHospitales(int id, string nombre, string direccion, String tlf, int camas)
        {
            Hospital hospi = new Hospital();
            hospi.IdHospital = id;
            hospi.Nombre = nombre;
            hospi.Direccion = direccion;
            hospi.Telefono = tlf;
            hospi.Camas = camas;
            this.context.Hospitales.Add(hospi);
            this.context.SaveChanges();

        }
    }
}