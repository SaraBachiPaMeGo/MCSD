using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoAdo.Datos
{
    public class Class13Datos
    {
        String cadena;
        SqlCommand com;
        SqlConnection cn;
        SqlDataAdapter ad;
        DataTable tabla;
        public Class13Datos(){
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.ad = new SqlDataAdapter();
            ad.SelectCommand = new SqlCommand();
            ad.SelectCommand.Connection = cn;
            //ad.SelectCommand
        }

        public List<Departamento> CargarDepartamentos() {
            String sql = "SELECT * FROM DEPT";
            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            this.tabla = new DataTable();
            List<Departamento> listadep = new List<Departamento>();
            this.ad.Fill(tabla);
            foreach (DataRow row in tabla.Rows)
            {
                Departamento dep = new Departamento();
                dep.NumeroDept = int.Parse(row["DEPT_NO"].ToString());
                dep.NombreDept = row["DNOMBRE"].ToString();
                dep.LocDept = row["LOC"].ToString();
                listadep.Add(dep);
            }

            return listadep;
        }

        public void ModificarDep(int dept_no, String nombre, String local) {

            String sql = "UPDATE DEPT SET DNOMBRE = @NOMBRE, LOC = @LOCAL WHERE DEPT_NO = @NUM";

            this.com.Parameters.AddWithValue("@NUM", dept_no);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@LOCAL", local);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            CargarDepartamentos();
        }

        public void EliminarDep(int dept_no) {
            String sql = "DELETE DEPT WHERE DEPT_NO = @NUM";
            this.com.Parameters.AddWithValue("@NUM", dept_no);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            
            this.com.Parameters.Clear();

            CargarDepartamentos();
        }

        public void InsertarDep(int dept_no, String nombre, String local) {
            String sql = "INSERT INTO DEPT VALUES (@NUM,@NOMBRE,@LOCAL)";

            this.com.Parameters.AddWithValue("@NUM", dept_no);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@LOCAL", local);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            CargarDepartamentos();
        }
    }
}
