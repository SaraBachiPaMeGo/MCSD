using SeguridadEmpleados.Data;
using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadEmpleados.Repositories
{
    public class RepositoryEmpleados
    {
        ContextoHospital context;
        public RepositoryEmpleados()
        {
            this.context = new ContextoHospital();
        }

        public List<Empleados> GetEmpleados()
        {
            var consulta = from datos in context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public Empleados ExisteEmpleado(String apellido, int emp_no)
        {
            Empleados emp = context.Empleados.SingleOrDefault<Empleados>
                (z => z.Emp_no == emp_no && z.Nombre == apellido);
            return emp;
        }
        //Necesitamos este método porque el ticket sólo puede contener
        //una cosa y en este caso sólo tiene el id del Empleado
        public Empleados BuscarEmp(int emp_no)
        {
            Empleados emp = context.Empleados.SingleOrDefault(z => z.Emp_no == emp_no);
            return emp;
        }

        public void ModificarEmpleado(int empno, String apellido, String oficio, int salario)
        {
            Empleados emp = this.BuscarEmp(empno);
            emp.Nombre = apellido;
            emp.Oficio = oficio;
            emp.Salario = salario;

            this.context.SaveChanges();
        }
    }
}