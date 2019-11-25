using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoAdo.Datos
{
    public class Class10Datos
    {
        SqlConnection cn;
        SqlDataReader reader;
        String cadena;
        SqlCommand com;
        public Class10Datos() {
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
        }

        public List<Departamento> GetDepartamentos() {
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM DEPT";
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            List<Departamento> listaDepartamentos = new List<Departamento>();

            while (this.reader.Read()) {
                Departamento dep = new Departamento();

                int numDept = int.Parse(this.reader["DEPT_NO"].ToString());
                String nombre = this.reader["DNOMBRE"].ToString();
                String loc = this.reader["LOC"].ToString();

                dep.NumeroDept = numDept;
                dep.NombreDept = nombre;
                dep.LocDept = loc;
                listaDepartamentos.Add(dep);
            }

            this.cn.Close();
            this.reader.Close();
            return listaDepartamentos;
        }

        public List<Empleado> GetEmpleado() {
            List<Empleado> listaEmpleados = new List<Empleado>();

            String sql = "SELECT DEPT_NO, APELLIDO, SALARIO, OFICIO FROM EMP";

            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {
                Empleado emp = new Empleado();

                int num_dept = int.Parse(this.reader["DEPT_NO"].ToString());
                String ape = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                String oficio = this.reader["OFICIO"].ToString();

                emp.Num_Dept = num_dept;
                emp.Apellido = ape;
                emp.Salario = salario;
                emp.Oficio = oficio;

                listaEmpleados.Add(emp);
            }

            this.cn.Close();
            this.reader.Close();

            return listaEmpleados;
        }

        public List<Empleado> BuscarEmp(int dept_num) {
            String sql = "SELECT * FROM EMP WHERE DEPT_NO = @DEPT_NUM";

            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@DEPT_NUM", dept_num);
            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            List<Empleado> listaEmp = new List<Empleado>();

            while (this.reader.Read()) {
                Empleado emp = new Empleado();

                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Num_Dept = int.Parse(this.reader["DEPT_NO"].ToString());
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
                emp.Oficio = this.reader["OFICIO"].ToString();

                listaEmp.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();

            return listaEmp;
        }
    }
}
