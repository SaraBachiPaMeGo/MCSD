using ProyectoMVCDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCDatos.Repositories
{
    public class RepositoryHospital
    {
        ContextoHospitalDataContext context;
        public RepositoryHospital()
        {
            context = new ContextoHospitalDataContext();
        }

        public List<HOSPITAL> GetHospital() {
            var consulta = from datos in context.HOSPITALs
                           select datos;
            return consulta.ToList();
        }

        public List<PLANTILLA> GetPlantilla(int cod_Hospi)
        {
            var consulta = from datos in context.PLANTILLAs
                           where datos.HOSPITAL_COD == cod_Hospi
                           select datos;
            return consulta.ToList();
        }

        public void DeletePlantilla(int emp_no)
        {
            context.EliminarPlantilla(emp_no);
            
        }
    }

    
}