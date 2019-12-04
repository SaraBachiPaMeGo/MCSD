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
            //GetDepartamentos();
        }
    }
}