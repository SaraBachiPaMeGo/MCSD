using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEntityFramework.Models
{
    public class ModeloDepartamento
    {
        ContextoHospital contexto;
        public ModeloDepartamento()
        {
            this.contexto = new ContextoHospital();
        }

        //METODO PARA PAGINAR DEPARTAMENTOS 
        public PAGINAR_DEPT_Result PaginarDepartamentos(int posicion)
        {
            var resultado = contexto.PAGINAR_DEPT(posicion);
            return resultado.FirstOrDefault();
        }

        public int GetNumeroDepartamentos()
        {
            var consulta = (from datos in contexto.DEPT
                            select datos).Count();
            return consulta;
        }
    }
}