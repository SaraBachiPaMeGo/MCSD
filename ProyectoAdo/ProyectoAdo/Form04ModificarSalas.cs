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
    public partial class Form04ModificarSalas : Form
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();

            CargarSalas();            
        }

        private void CargarSalas() {

            this.lstSalas.Items.Clear();

            String sql = "Select DISTINCT NOMBRE from SALA";

            this.com.Connection = this.cn; // Conexión
            this.com.CommandType = CommandType.Text; // Tipo de consulta
            this.com.CommandText = sql; // Consulta

            this.cn.Open(); // Abrir conexión 

            this.reader = this.com.ExecuteReader(); //Ejecutar la consulta

            //Leer registros WHILE
            while (this.reader.Read()) {

                String nombreSala = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombreSala);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)

        {
            string oldname= this.lstSalas.SelectedItem.ToString();
            string newname = this.txtNombre.Text;
            
            String sql = "UPDATE SALA SET NOMBRE='"+ newname + "'WHERE NOMBRE ='" 
                +oldname + "')";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            int afectados = this.com.ExecuteNonQuery();

            this.cn.Close();
            MessageBox.Show("Registros afectados " + afectados);

            CargarSalas();
        }
    }
}
