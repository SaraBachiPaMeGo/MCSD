using ProyectoMVCDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ProyectoMVCDatos.Repositories
{
    public class RepositoryEmpleado
    {
        ContextoHospitalDataContext context;
        public RepositoryEmpleado() {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            this.context = new ContextoHospitalDataContext(cadena);            
        }

        //Metodo que nos devuelva los oficios
        public List<String> GetOficios() {
            var consulta = (from datos in context.EMPs
                           select datos.OFICIO).Distinct();
            
            return consulta.ToList();
        }

        //Método para devolver los empleados por un oficio
        public List<EMP> GetEmpleado(String oficio) {
            var consulta = from datos in context.EMPs
                           where datos.OFICIO == oficio
                           select datos;
            return consulta.ToList();
        }
    }
}