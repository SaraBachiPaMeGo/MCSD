using MvcProject.Data;
using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.Repositories
{
    public class RepositoryEmpleados
    {
        ContextoEmpleados context;
        public RepositoryEmpleados()
        {
            this.context = new ContextoEmpleados();
        }

        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado>
            GetEmpleadosSeleccionados(List<int> seleccionados)
        {
            var consulta =
                from datos in context.Empleados
                where seleccionados.Contains(datos.EmpleadoNumero)
                select datos;
            return consulta.ToList();
        }
    }
}