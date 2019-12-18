using ProyectoPruebaPractica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPruebaPractica.Repositories
{
    public class RepositoryEmpleado
    {
        ContextoHospitak context;

        public RepositoryEmpleado() {
            context = new ContextoHospitak();
        }

        public List<EMP> GetEmpleados()
        {
            var consulta = from datos in context.EMP
                           select datos;
            
            return consulta.ToList();
        }

        public List<EMP> GetEmpleadosOrdenados(int num, String campo)
        {
            var consulta = from datos in context.EMP
                            select datos;
            if (num == 1)
            {
                switch (campo) {
                    case "APELLIDO":
                        consulta.OrderBy(Z => Z.APELLIDO);
                        break;
                    case "FECHA_ALT":
                        consulta.OrderBy(Z => Z.FECHA_ALT);
                        break;
                    case "SALARIO":
                        consulta.OrderBy(Z => Z.SALARIO);
                        break;


                }
                return consulta.ToList();
            }
            else {
                switch (campo)
                {
                    case "APELLIDO":
                        consulta.OrderByDescending(Z => Z.APELLIDO);
                        break;
                    case "FECHA_ALT":
                        consulta.OrderByDescending(Z => Z.FECHA_ALT);
                        break;
                    case "SALARIO":
                        consulta.OrderByDescending(Z => Z.SALARIO);
                        break;
                }

                return consulta.ToList();
            }            
        }


    }
}