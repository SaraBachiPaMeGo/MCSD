using ProyectoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

//CREATE PROCEDURE SubirSalarioOficio
//(@oficio nvarchar(10),@incr int)
//as
//	UPDATE EMP SET SALARIO = SALARIO + @INCR

//    WHERE OFICIO = @OFICIO
//go

//Alter VIEW VISTADOCPLANT
//AS

//    SELECT DOCTOR_NO, APELLIDO, ESPECIALIDAD, SALARIO, HOSPITAL.NOMBRE
//     FROM DOCTOR
//     INNER JOIN HOSPITAL

//    ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
//    UNION

//    SELECT EMPLEADO_NO, APELLIDO, FUNCION, SALARIO, Hospital.NOMBRE
//    FROM PLANTILLA
//    INNER JOIN HOSPITAL

//    ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//GO

//Alter PROCEDURE PROCEDVISTA
//(@POSICION INT, @REGISTROS INT OUT)
//AS
//    SELECT @REGISTROS = COUNT(APELLIDO) FROM VistaDoctoresPlantilla


//    SELECT* FROM
//    (
//    SELECT ROW_NUMBER() OVER (ORDER BY DOCTOR_NO) AS POSICION,
//    DOCTOR_NO, APELLIDO, ESPECIALIDAD, SALARIO, NOMBRE

//    FROM VISTADOCPLANT
//	)TodosEmp
//    WHERE POSICION> @POSICION*3 AND POSICION<= (@POSICION*3) +3
//GO

//ALTER VIEW EMPEADOSDEPT
//AS

//    SELECT ISNULL(
//    ROW_NUMBER() OVER (ORDER BY APELLIDO),0) AS
//    POSICION,

//    EMP.APELLIDO, EMP.OFICIO,
//	EMP.SALARIO,DEPT.LOC, DEPT.DNOMBRE
//    FROM EMP
//    INNER JOIN DEPT

//    ON EMP.DEPT_NO = DEPT.DEPT_NO
//	-- NO ADMITIRÁ VALORES NULOS, EL 0 VALOR POR DEFECTO
//	-- Si no hay pk hacemos el row_number para que se convierta
//	-- en la pk
//GO

namespace ProyectoEntityFramework.Repositories
{
    public class RepositoryEmpleaddo
    {
        ContextoHospital context;
        public RepositoryEmpleaddo() {
            context = new ContextoHospital();
        }

        public List<String> GetOficios()
        {
            var consulta = (from datos in context.EMP
                            select datos.OFICIO).Distinct();
            return consulta.ToList();
        }

        public List<EMP> GetEmpleados(List<String> oficio) 
        {
            //Lo podría hacer con un Array pero trabajamos con colecciones
            var consulta = from datos in context.EMP
                           where oficio.Contains(datos.OFICIO) //Comparamos los datos que ha elegido el usuario y
                           //lo compara con los oficios que están en la BBDD
                           select datos;
            return consulta.ToList();
        }

        public void IncrementarSalario(List<String> oficio, int incr)
        {
            foreach (String ofi in oficio) { 
                 context.SubirSalarioOficio(ofi, incr);
            }
        }

        public void VerProcedimiento() {
            //En el caso de que devuelva un complextype
            //var objetos = context.TODOSEMP();
            //List<TODOSEMP_Result> resultados = objetos.ToList();
            //Se suele separar porque hay a veces que da excepción
            var objetos= context.TODOSEMP();
            List<EMP> listaEmp = objetos.ToList();
        }

        public List<EMP> GetEmpleadoPag(int posicion) {//
            var consulta = from dato in context.EMP
                           select dato;// Hay que ordenarlos
            //var resultado = coleccion.Skip(pagAMostrar * numElementosPorPagina).Take(numElementosPorPagina);           

            List<EMP> coleccion = consulta.ToList();
            var datos = coleccion.Skip(posicion).Take(5);

            //var inicio = pagina *5;
            //var consulta = (from dato in context.EMP
            //               orderby dato.Apellido
            //               select dato).Skip(inicio).Take(5);

            return datos.ToList();//datos.ToList();
        }

        public int GetRegistros() {
            var consulta = from dato in context.EMP
                           select dato;
            int numRegistros = consulta.Count();
            //return context.plantilla.count();
            return numRegistros;
        }

        public List<VISTADOCPLANT> GetTodosEmpl(int posicion, int numReg) 
        {
            //var consulta = (from datos in context.VISTADOCPLANT
            //                orderby datos.DOCTOR_NO
            //               select datos).Skip(posicion).Take(3);
            ObjectParameter registro = new ObjectParameter("REGISTROS", typeof(int));

            var datos = context.PROCEDVISTA(posicion, registro, numReg);

            return datos.ToList();
        }

        public int NumRegistrosEmp() 
        {
            return context.VISTADOCPLANT.Count();
        }

        public List<EMPEADOSDEPT> GetEmpDept() 
        {
            var consulta = from datos in context.EMPEADOSDEPT
                           select datos;
            return consulta.ToList();
        }

        public EMPEADOSDEPT BuscarEmp(int posicion) 
        {
            return context.EMPEADOSDEPT.SingleOrDefault(z => z.POSICION == posicion);
        }



    }
}