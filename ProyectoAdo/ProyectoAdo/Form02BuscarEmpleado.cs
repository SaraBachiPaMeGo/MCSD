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
    public partial class Form02BuscarEmpleado : Form
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
        public Form02BuscarEmpleado()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(this.cadena);
            this.com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dato = this.txtNombre.Text;
            // String sql = "SELECT APELLIDO FROM EMP WHERE DEPT_NO=" + dato;
            String sql = "SELECT APELLIDO FROM EMP WHERE OFICIO ='" + dato +"'";

            // Configuramos todos los datos para las conexiones 
            // Entrar y salir
            this.com.Connection = this.cn; //Conexion
            this.com.CommandType = CommandType.Text; // Tipo de consulta
            this.com.CommandText = sql; // Consulta a realizar

            //Abrimos la conexión

            //if (this.cn.State == ConnectionState.Closed)
            //{
                this.cn.Open();
            //}
                        
            this.reader = this.com.ExecuteReader(); //Ejecutamos la consulta 
            this.lstEmp.Items.Clear();

            //Leemos todos los registros que la consulta nos devuelva --> WHILE

            while (this.reader.Read()) {
                String apellido = this.reader["APELLIDO"].ToString();
                this.lstEmp.Items.Add(apellido);
            }

            //Liberamos el reader y la conexion
            this.reader.Close();
            this.cn.Close();
        }
    }
}
