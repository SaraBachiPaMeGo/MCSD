using ProyectoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//CREATE PROCEDURE PAGINAR_DEPT

//(@POSICION INT)

//AS 

//--UN SELECT DE UN SELECT

//SELECT* FROM

//(SELECT ROW_NUMBER()

//OVER (ORDER BY DEPT_NO) AS POSICION

//, DEPT_NO, DNOMBRE, LOC

//FROM DEPT) DEPARTAMENTOS

//WHERE POSICION = @POSICION

//GO

namespace ProyectoEntityFramework.Repositories
{
    public class RepositoryDepartamento
    {
        ContextoHospital context;

        public RepositoryDepartamento()
        {
            context = new ContextoHospital();
        }

        public List<DEPT> GetDepartamentos()
        {
            var consulta = from datos in context.DEPT
                           select datos;
            return consulta.ToList();
        }

        public DEPT BuscarDept(int deptno)
        {
            //var consulta = from datos in context.DEPT
            //               where datos.DEPT_NO == deptno
            //               select datos;

            DEPT dept = context.DEPT.SingleOrDefault(z => z.DEPT_NO == deptno);
            //Si no hay datos single... devuelve 1 o null
            return dept;
        }

        public void InsertarDepartamento(int deptno, String nombre, String loc) 
        {
            DEPT dept = new DEPT();

            dept.DEPT_NO = deptno;
            dept.DNOMBRE = nombre;
            dept.LOC = loc;

            context.DEPT.Add(dept); //TODAS LAS TABLAS VAN A TENER UNA COLECCIÓN
            //SOLO SE ACCEDE A LA COLECCIÓN A TRAVÉS DE CONTEXT
            context.SaveChanges();
        }

        public void ModificarDepartamento(int deptno, String nombre, String loc)
        {
            DEPT dept = this.BuscarDept(deptno);

            dept.DNOMBRE = nombre;
            dept.LOC = loc;

            context.SaveChanges();
        }

        public void EliminarDepartamento(int deptno)
        {
            DEPT dept = this.BuscarDept(deptno);

            context.DEPT.Remove(dept);
            context.SaveChanges();
        }

        
        public PAGINAR_DEPT_Result PaginarDepartamentos(int position)
        {
            var resultado = this.context.PAGINAR_DEPT(position);
            return resultado.FirstOrDefault();
        }
        public int GetNumroDepartamentos()
        {
            return context.DEPT.Count();
        }

    }
}