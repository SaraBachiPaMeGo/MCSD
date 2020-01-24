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

        public List<String> GetOficios()
        {
            var consulta = (from datos in context.Empleados
                            select datos.Oficio).Distinct();
            //this.context.Empleados.Distinct(consulta);
            return consulta.ToList();
        }
        
        public void Create(int empno, String nombre, String oficio, int dir, int salario, int dept_no)
        {
            Empleado emp = new Empleado();
            //Empleado jefe = BuscarEmp(dir);

            //if (emp.Salario >= jefe.Salario) {
            //    String mensaje = "Salario más alto que el jefe";
            //    this.InsetarExcepcion(mensaje,"" ,DateTime.Now);
            //}
            //else {

                emp.Emp_no = empno;
                emp.Nombre = nombre;
                emp.Oficio = oficio;
                emp.Salario = salario;
                emp.Dept_no = dept_no;
                emp.FECHA_ALT = DateTime.Now;
                emp.Dir = dir;

                this.context.Empleados.Add(emp);
                this.context.SaveChanges();
            //}
        }

        public void Modificar(int empno, String nombre, String oficio, int salario, int dept_no)
        {
            Empleado emp = this.BuscarEmp(empno);

            nombre = emp.Nombre;
            oficio = emp.Oficio;
            salario = emp.Salario;
            dept_no = emp.Dept_no;

            this.context.Empleados.Add(emp);
            this.context.SaveChanges();
        }

        public void Delete(int empno)
        {
            Empleado emp = this.BuscarEmp(empno);

            this.context.Empleados.Remove(emp);
            this.context.SaveChanges();
        }

        private int GetMaxIdException ()
        {
            var consulta = from datos in context.Excepciones
                           select datos;
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else {
                return consulta.Max(z => z.ExceptionID) + 1;
            }
        }

        public void InsetarExcepcion(String mensaje, String controlador, DateTime fecha)
        {
            Excepcion ex = new Excepcion();

            ex.ExceptionID = this.GetMaxIdException();
            ex.Message = mensaje;
            ex.Controller = controlador;
            ex.Date = fecha;

            this.context.Excepciones.Add(ex);
            this.context.SaveChanges();
        }
    }    
}