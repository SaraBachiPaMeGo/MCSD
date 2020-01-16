using InyeccionDepartamentos.Data;
using InyeccionDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionDepartamentos.Repositories
{
    public class RepositoryHospital 
    {
        IContextoHospital context;

        public RepositoryHospital(IContextoHospital context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        public Departamento BuscarDepartamento(int num) 
        {
            var consulta = from datos in context.Departamentos
                           where datos.Dept_no == num
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void InsertarDept(int num, String nombre, String loc) 
        {
            Departamento dep = new Departamento();

            dep.Dept_no = num;
            dep.DNombre = nombre;
            dep.Loc = loc;

            this.context.Departamentos.Add(dep);
            this.context.SaveChanges();
        }

        public void UpdateDepartamento(int num, String nombre, String loc)
        {
            var consulta = from datos in context.Departamentos
                           where datos.Dept_no == num
                           select datos;
            Departamento dep = consulta.FirstOrDefault();

            dep.DNombre = nombre;
            dep.Loc = loc;
            this.context.SaveChanges();
        }
    }
}