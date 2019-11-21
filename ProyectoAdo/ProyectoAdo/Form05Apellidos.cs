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

#region PROCEDIMIENTOS ALMACENADOS
            //CREATE PROCEDURE TODOSEMP
            //AS
            //SELECT* FROM EMP
            //GO

            //CREATE PROCEDURE BUSCAREMP
            //(@APE NVARCHAR(10))
            //AS

            //    SELECT* FROM EMP
            //   WHERE APELLIDO LIKE @APE + '%'
            //GO

            //EXEC BUSCAREMP 'Bach'
#endregion

namespace ProyectoAdo
{
    public partial class Form05Apellidos : Form
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        SqlParameter param;

        public Form05Apellidos()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(this.cadena);
            this.com = new SqlCommand();

            //param = new SqlParameter();
            //param.ParameterName = "@APE";
            ////todos los parámetros los utilicemos o no tienen que tener UN VALOR POR DEFECTO
            //param.DbType = DbType.String;
            //param.Value = "";

            //this.com.Parameters.Add(param);

            CargarEmpleados();
        }

        private void CargarEmpleados() {
            //String sql = "SELECT * FROM EMP ";
            String sql = "TODOSEMP"; // NOMBRE DEL PROCEDIMIENTO
            // solamente los puedo llmar con el número exacto de parámetros que necesita, por eso no funciona

            this.com.Connection = this.cn;
            //this.com.CommandType = CommandType.Text; // Tipo de consulta
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql; // Consulta

            this.cn.Open();//Abrir la conexión

            this.reader = this.com.ExecuteReader();
            this.lstApellido.Items.Clear();

            while (this.reader.Read())
            {
                String apellido = this.reader["APELLIDO"].ToString();
                this.lstApellido.Items.Add(apellido);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sql = "BUSCAREMP";
            // POR CADA @ UNA CLASE PARAMETER

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@APE";
            param.Value = this.txtNombre.Text;
            param.DbType = DbType.String; // se utiliza en casos explícitos, oracle. Cuando son tipos primitivos
            // no importa

            // Los parámetros se almacenan dentro del command
            // No podemos tener parámetros con nombres repetidos

            this.com.Parameters.Add(param);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure; // Tipo de consulta
            this.com.CommandText = sql; // Consulta

            this.cn.Open();//Abrir la conexión

            this.reader = this.com.ExecuteReader();
            this.lstApellido.Items.Clear();

            while (this.reader.Read()) {
                String apellido = this.reader["APELLIDO"].ToString();
                this.lstApellido.Items.Add(apellido);
            }

            this.reader.Close();
            this.cn.Close();
            //Limpiamos los parámetros
            this.com.Parameters.Clear();

        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            String sql = "SELECT APELLIDO FROM EMP WHERE APELLIDO LIKE @APE";
            // POR CADA @ UNA CLASE PARAMETER

            param.Value = this.txtNombre.Text + "%"; // Si lo detecta lo utiliza y sino no 
            
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text; // Tipo de consulta
            this.com.CommandText = sql; // Consulta

            this.cn.Open();//Abrir la conexión

            this.reader = this.com.ExecuteReader();
            this.lstApellido.Items.Clear();

            while (this.reader.Read())
            {
                String apellido = this.reader["APELLIDO"].ToString();
                this.lstApellido.Items.Add(apellido);
            }

            this.reader.Close();
            this.cn.Close();

        }
    }
}
