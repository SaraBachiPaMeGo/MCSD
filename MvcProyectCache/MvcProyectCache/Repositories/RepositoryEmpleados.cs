using MvcProyectCache.Data;
using MvcProyectCache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProyectCache.Repositories
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
    }
}