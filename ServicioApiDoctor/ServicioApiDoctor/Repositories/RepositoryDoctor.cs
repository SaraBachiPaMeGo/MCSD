using ServicioApiDoctor.Data;
using ServicioApiDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioApiDoctor.Repositories
{
    public class RepositoryDoctor
    {
        ContextoDoctor context;

        public RepositoryDoctor()
        {
            this.context = new ContextoDoctor();
        }

        public List<Doctor> GetDoctores()
        {
            var consulta = from datos in context.Doctores
                           select datos;
            return consulta.ToList();
        }
        public Doctor BuscarDoctor( int doctor_no)
        {
            List<Doctor> listaDoc = GetDoctores();

            var dato = listaDoc.Where(z =>z.Doctor_no == doctor_no);
            return dato.FirstOrDefault();
        }
    }
}