using ProyectoErrores.Data;
using ProyectoErrores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoErrores.Repositories
{    
    public class RepositoryEmpleados
    {
        
        ContextoHospital context;

        public RepositoryEmpleados()
        { 
            this.context = new ContextoHospital();
        }

        public Empleado BuscarEmp(int emp_no)
        {
            Empleado emp = context.Empleados.SingleOrDefault(z => z.Emp_no == emp_no);
            return emp;
        }

        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }

        //Crear y borrar
        //Director y Presidente

        public void Create(int empno, String nombre, String oficio, int salario)
        {
            Empleado emp = new Empleado();

            emp.Emp_no =empno ;
            emp.Nombre = nombre;
            emp.Oficio = oficio;
            emp.Salario = salario;

            this.context.Empleados.Add(emp);
            this.context.SaveChanges();
        }

        public void Delete(int empno)
        {
            Empleado emp = this.BuscarEmp(empno);

            this.context.Empleados.Remove(emp);
            this.context.SaveChanges();
        }
        
    }

    
}