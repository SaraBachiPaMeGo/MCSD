using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoAdo
{
    public partial class Form03EliminarEnfermo : Form
    {
        SqlDataReader reader;
        SqlConnection cn;
        SqlCommand com;
        String cadena;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();

            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();

            this.CargarEnfermos();
        }

        private void CargarEnfermos() {

            this.lstEnfermos.Items.Clear();

            String sql = "SELECT INSCRIPCION, APELLIDO FROM ENFERMO ";

            this.com.Connection = this.cn;// Conexion
            this.com.CommandType = CommandType.Text;// Tipo de consulta
            this.com.CommandText = sql;// Consulta

            this.cn.Open(); // Abrir la conexión

            this.reader = this.com.ExecuteReader(); // Ejecutar la consulta

            // Leer registro con un while
            while (this.reader.Read())
            {
                String apellido = this.reader["APELLIDO"].ToString();
                String inscrip = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(apellido + " - " + inscrip);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.com.CommandType = CommandType.Text;
            String sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=" + this.txtInscrip.Text;

            this.com.CommandText = sql;

            cn.Open();

            //Las consultas de acción se ejecutan con ExecuteNoNQuery() y devuelven 
            // un int con el numero de registros afectados
            int afectados = this.com.ExecuteNonQuery();
            cn.Close();

            CargarEnfermos();
            MessageBox.Show("Enfermos eliminados" + afectados);
        }
    }
}
