using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ProyectoMVCDatos.Models;

namespace ProyectoMVCDatos.Repositories
{
    public class RepositoryDoctor
    {
        ContextoHospitalDataContext context;
        public RepositoryDoctor() {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            context = new ContextoHospitalDataContext(cadena);
        }

        public List<DOCTOR> GetDoctor() {

            var consulta = from datos in context.DOCTORs
                           select datos;
            return consulta.ToList();
        }

        public DOCTOR BuscarDoctor(int id) {
            var consulta = from datos in context.DOCTORs
                           where datos.DOCTOR_NO == id
                           select datos;
            //Debemos devolver un único objeto
            //y en consulta tenemos un conjunto
            //utilizamos el método first 
            //Y si no me devuelve ningún resultado?
            //Tenemos un método que devuelve null si 
            //no encuentra el registro: FirstOrDefault()
            return consulta.FirstOrDefault();
        }

        //Método para insertar
        public void InsertarDoctor(int hospicod, int id, String apellido, String especialidad, int salario) {

            DOCTOR doc = new DOCTOR();
            doc.DOCTOR_NO = id;
            doc.APELLIDO = apellido;
            doc.ESPECIALIDAD = especialidad;
            doc.HOSPITAL_COD = hospicod;
            doc.SALARIO = salario;
            //Tenemos un método para insertar de forma
            //temporal en la colección insertofsubmit
            //Ese objeto no estáría en la base de datos
            context.DOCTORs.InsertOnSubmit(doc);
            //Hasta que no realicemos SUBMIT no realiza
            //el insert en BBDD
            context.SubmitChanges(); //Realiza el insert sobre la BBDDs

        }

        public void ModificarDoctor(int hospicod, int id, String apellido, String especialidad, int salario) {

            DOCTOR doc = this.BuscarDoctor(id);
            doc.APELLIDO = apellido;
            doc.ESPECIALIDAD = especialidad;
            doc.HOSPITAL_COD = hospicod;
            doc.SALARIO = salario;
            context.SubmitChanges();
        }

        public void EliminarDoctor(int id) {

            DOCTOR doc = this.BuscarDoctor(id);
            //Tenemos un método para eliminar: DeleteOnSubmit
            //de forma temporal
            context.DOCTORs.DeleteOnSubmit(doc);
            context.SubmitChanges(); //Hacemos el delete sobre la BBDD
        
        }
    }
}