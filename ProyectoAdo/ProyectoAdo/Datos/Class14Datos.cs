using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoAdo.Datos
{
    public class Class14Datos
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        SqlDataAdapter ad;
        DataTable tabla;
        public Class14Datos() {
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            ad = new SqlDataAdapter();
            ad.SelectCommand = this.com;
            ad.SelectCommand.Connection = this.cn;
        }

        public List<Trabajadores> GetTrabajadores() {
            String sql = "SELECT * FROM VistaTrabajadores";

            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            tabla = new DataTable();
            this.ad.Fill(tabla);


            List<Trabajadores> listaTrab = new List<Trabajadores>();

            foreach (DataRow row in tabla.Rows) {
                Trabajadores trabajador = new Trabajadores();

                trabajador.apellido = row["APELLIDO"].ToString();
                trabajador.trabajo = row["ESPECIALIDAD"].ToString();
                trabajador.Salario = int.Parse(row["SALARIO"].ToString());
                trabajador.Numero = int.Parse(row["NUMERO"].ToString());

                listaTrab.Add(trabajador);
            }


            return listaTrab;
        }

        public void UpdateTrabajadores(int num, String nombre, int salario) {
            String sql = "UPDATE VistaTrabajadores SET APELLIDO = @APE, SALARIO=@SALARIO "
                + "WHERE NUMERO = @NUM";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@APE", nombre);
            this.com.Parameters.AddWithValue("@SALARIO", salario);
            this.com.Parameters.AddWithValue("@NUM", num);

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetTrabajadores();
        }

        public void IncrementarSalario(int incr) {
            String sql = "UPDATE VistaTrabajadores SET SALARIO = SALARIO + @INCR";

            this.com.Parameters.AddWithValue("@INCR", incr);
            

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetTrabajadores();

        }
    }
}
