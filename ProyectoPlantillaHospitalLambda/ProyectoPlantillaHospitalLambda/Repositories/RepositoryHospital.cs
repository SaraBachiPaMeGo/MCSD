using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ProyectoPlantillaHospitalLambda.Models;

//create VIEW VistaDoctoresPlantilla
//as
//	SELECT DOCTOR.APELLIDO,
//    DOCTOR.ESPECIALIDAD,
//    DOCTOR.SALARIO
//    FROM DOCTOR
//    UNION

//    SELECT PLANTILLA.APELLIDO,
//    PLANTILLA.FUNCION,
//    PLANTILLA.SALARIO
//    FROM PLANTILLA
//go

namespace ProyectoPlantillaHospitalLambda.Repositories
{
    public class RepositoryHospital
    {
        ContextoHospitalDataContext context;
        String cadena;
        public RepositoryHospital() {
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            context = new ContextoHospitalDataContext(cadena);
        }

        public List<HOSPITAL> GetHospitales() {
            var consulta = from datos in context.HOSPITALs
                           select datos;
            
            return consulta.ToList();
        }

        public List<DoctoresPlantilla> GetDoctorPlantilla(int hospi_cod) {
            var consulta = from datos in context.VistaDoctoresPlantillas
                           where datos.HOSPITAL_COD == hospi_cod
                           select datos;

            List<DoctoresPlantilla> listaEmpleados = new List<DoctoresPlantilla>();

            foreach (var d in consulta) {

                DoctoresPlantilla emp = new DoctoresPlantilla();
                emp.apellido = d.APELLIDO;
                emp.trabajo = d.ESPECIALIDAD;
                emp.salario = d.SALARIO.GetValueOrDefault();
                emp.Hospital_cod = d.HOSPITAL_COD.GetValueOrDefault();
                emp.MediaSalarial = context.VistaDoctoresPlantillas.Average(x => x.SALARIO).GetValueOrDefault();
                emp.SumaSalarial = context.VistaDoctoresPlantillas.Sum(z => z.SALARIO).GetValueOrDefault();                

                listaEmpleados.Add(emp);
            }

            return listaEmpleados;
        }
    }
}