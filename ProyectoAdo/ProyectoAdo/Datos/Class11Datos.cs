using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoAdo.Datos
{
    public class Class11Datos
    {
        SqlDataReader reader;
        SqlConnection cn;
        SqlCommand com;
        String cadena;

        public Class11Datos() {

            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadena);
            this.com = new SqlCommand();
            
        }

        public List<Hospital> ListarHospital() {
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT NOMBRE, HOSPITAL_COD FROM HOSPITAL";

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            List<Hospital> listaHospital = new List<Hospital>();

            while (this.reader.Read())
            {
                Hospital hospi = new Hospital();

                hospi.Cod_Hospi = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospi.NombreHospi = this.reader["NOMBRE"].ToString();

                listaHospital.Add(hospi);
            }

            this.cn.Close();
            this.reader.Close();
            return listaHospital;
        }

        public List<Plantilla> ListarPlantilla(int cod_hospital) {

            this.com.Parameters.AddWithValue("@COD_HOSPI", cod_hospital);

            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT APELLIDO, FUNCION, SALARIO FROM PLANTILLA" +
                " WHERE HOSPITAL_COD = @COD_HOSPI";

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            List<Plantilla> listaPlantilla = new List<Plantilla>();

            while (this.reader.Read()) {
                Plantilla plant = new Plantilla();

                plant.Apellido = this.reader["APELLIDO"].ToString();
                plant.Funcion = this.reader["FUNCION"].ToString();
                plant.Salario = int.Parse(this.reader["SALARIO"].ToString());

                listaPlantilla.Add(plant);
            
            }
            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();
            return listaPlantilla;
        }
    }
}
