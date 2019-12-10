using ProyectoMVCDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//CREATE PROCEDURE EliminarDept
//(@dept_no int)
//as
//	delete FROM DEPT WHERE DEPT_NO = @dept_no
//go

//CREATE PROCEDURE ModificarSalario
//(@INCR int, @DEPT_NO int)
//AS
// --	from datos in context.EMPs
//  --    where datos.DEPT_NO == numero
//  --    select datos;
//UPDATE EMP SET SALARIO = SALARIO + @INCR

//    WHERE EMP.DEPT_NO = @dept_no
//GO

namespace ProyectoMVCDatos.Repositories
{
    public class RepositoryDepartamentos
    {
        ContextoHospitalDataContext context;

        public RepositoryDepartamentos() {
            this.context = new ContextoHospitalDataContext();
        }

        //Realizamos todas las acciones de BBDD aquí

        public List<DEPT> GetDepartamentos() {
            var consulta = from datos in context.DEPTs
                           select datos;           

            return consulta.ToList(); 
        }

        public void EliminarDepto(int deptno) {
            context.EliminarDept(deptno);
        }

        public void ModificarEmpleados(int incr, int numero) {
            //var consulta = from datos in context.EMPs
            //               where datos.DEPT_NO == numero
            //               select datos;
             context.ModificarSalario(incr, numero);
  
        }
        public List<EMP> GetEmpleadosDepartamento(int numero) {
            var consulta = from datos in context.EMPs
                           where datos.DEPT_NO == numero
                           select datos;

            return consulta.ToList();
        }

        public ResumenDepartamentos GetResumenDepartamento(int deptno) {
            var consulta = from datos in context.EMPs
                           where datos.DEPT_NO == deptno
                           select datos;
            //Máximo salario, la media y las personas del departamento
            int? max = consulta.Max(z => z.SALARIO); //? puede que no devuelva datos
            int personas = consulta.Count(); //Coge todos los datos de la consulta
            //No hay que especificar el campo
            double? media = consulta.Average(z => z.SALARIO);
            //Creamos una clase en model para hacer un objeto y guardar estos 3 datos
            //No hay ningún objeto qie devuelva dos int y un String
            //El contexto crea las clases para cada una de las tablas
            //Si no hay ese tipo de tabla, la crearemos a mano
            ResumenDepartamentos resu = new ResumenDepartamentos();

            resu.MaximoSalario = max.GetValueOrDefault();
            resu.MediaSalarial = media.GetValueOrDefault();
            resu.Personas = personas;
            resu.Empleados = consulta.ToList();
            
            return resu;
        }
        
    }
}