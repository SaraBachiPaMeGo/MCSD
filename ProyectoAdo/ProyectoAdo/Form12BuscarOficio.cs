using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoAdo
{
    public partial class Form12BuscarOficio : Form
    {
        String cadena;
        SqlDataAdapter ad;
        DataTable tabla;
        public Form12BuscarOficio()
        {
            InitializeComponent();
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            tabla = new DataTable();
            //Al instanciar el adaptador, debemos indicar (opcional) la cadena de conexión y la consulta
            //String sql = "SELECT * FROM EMP";
            //this.ad = new SqlDataAdapter(sql, cadena);
            this.ad = new SqlDataAdapter();
            //Para conectarnos necesitamos:
            ad.SelectCommand = new SqlCommand();
            ad.SelectCommand.Connection = new SqlConnection(cadena);

            //Nos traemos los datos
            //this.ad.Fill(tabla);
            // Una tabla está compuesta por filas (DataRows) y columnas (DataColumn)
            //foreach (DataRow row in tabla.Rows) {
            //    String apellido = row["APELLIDO"].ToString();
            //    this.lstEmp.Items.Add(apellido);
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lstEmp.Items.Clear();
            tabla.Rows.Clear(); // Ó TABLA= NEW DATATABLE();
            
            String oficio = this.txtNombre.Text;
            ad.SelectCommand.Parameters.AddWithValue("@OFICIO", oficio);
            String sql = "SELECT * FROM EMP WHERE OFICIO = @OFICIO";

            // El comando se encunetra dentro del adapter en su propiedad
            //SelectCommand
            ad.SelectCommand.CommandType = CommandType.Text;
            ad.SelectCommand.CommandText = sql;
            ad.Fill(tabla);
            
            foreach (DataRow row in tabla.Rows) {
                this.lstEmp.Items.Add(row["APELLIDO"]);
            }

            ad.SelectCommand.Parameters.Clear();        
        }
    }
}
