using ProyectoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//CREATE PROCEDURE SubirSalarioOficio
//(@oficio nvarchar(10),@incr int)
//as
//	UPDATE EMP SET SALARIO = SALARIO + @INCR

//    WHERE OFICIO = @OFICIO
//go

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
    }
}