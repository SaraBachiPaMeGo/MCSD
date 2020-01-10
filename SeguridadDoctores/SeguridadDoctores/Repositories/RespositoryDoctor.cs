using SeguridadDoctores.Data;
using SeguridadDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadDoctores.Repositories
{
    public class RespositoryDoctor
    {
        ContextoHospital context;
        public RespositoryDoctor() 
        {
            this.context = new ContextoHospital();
        }
        public List<Doctor> GetDoctores() 
        {
            var consulta = from datos in context.Doctores
                           select datos;
            return consulta.ToList();
        }
        public Doctor BuscarDoctor(String apellido, int doctor_no) 
        {
            List<Doctor> listaDoc = GetDoctores();

            var dato = listaDoc.Where(z => z.Apellido == apellido && z.Doctor_no == doctor_no);
            return dato.FirstOrDefault();
        }
    }
}