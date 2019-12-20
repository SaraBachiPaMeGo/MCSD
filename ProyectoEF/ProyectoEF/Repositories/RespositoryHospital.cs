using ProyectoEF.Data;
using ProyectoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEF.Repositories
{
    public class RespositoryHospital
    {
        ContextoHospital context;

        public RespositoryHospital() 
        {
            this.context = new ContextoHospital();
        }

        public List<Hospital> GetHospitales() 
        {
            var consulta = from datos in context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public void CrearHospital(int codig, String nombre, String direccion, String tlf, int numCama)
        {
            Hospital hospi = new Hospital();

            hospi.CodHospi = codig;
            hospi.Nombre = nombre;
            hospi.Direccion = direccion;
            hospi.Tlf = tlf;
            hospi.NumCamas = numCama;

            context.Hospitales.Add(hospi);
            context.SaveChanges();

        }
    }
}