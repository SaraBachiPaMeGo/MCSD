using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionCore.Data;
using ValidacionCore.Models;

namespace ValidacionCore.Repositories
{
    public class RepositoryEmp
    {
        ContextoHospital context;
        public RepositoryEmp(ContextoHospital context)
        {
            this.context = context;
        }

        public Empleados BuscarEmp(String nombre, int id)
        {
            return context.Empleados.SingleOrDefault(z => z.Nombre == nombre && z.Emp_no == id);
        }

        public List<Empleados> GetEmpleados()
        {
            return context.Empleados.ToList();
        }

        public List<Empleados> BuscarSubord(int IdJefe)
        {
            var consulta = from datos in context.Empleados
                           where datos.Dir == IdJefe
                           select datos;
            return consulta.ToList();
        }
    }
}
