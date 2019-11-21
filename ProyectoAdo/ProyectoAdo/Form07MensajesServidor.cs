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
//CREATE PROCEDURE INSERTDEPT
//(@NUM int , @NOM nvarchar(10),@LOC nvarchar(10))
//AS
//    INSERT INTO DEPT VALUES(@NUM, @NOM, @LOC)
//GO

//ALTER PROCEDURE INSERTDEPT
//(@NUM int , @NOM nvarchar(10),@LOC nvarchar(10))
//AS
//    IF(UPPER(@LOC) = 'TERUEL')

//    BEGIN
//        PRINT 'LOCALIDAD NO VÁLIDA'
//	END
//    ELSE

//    BEGIN
//        INSERT INTO DEPT VALUES(@NUM, @NOM, @LOC)

//    END
//GO
#endregion

namespace ProyectoAdo
{
    public partial class Form07MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        String cadena;
        public Form07MensajesServidor()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(cadena);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
             CargarDept();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            //SOLAMENTE ENTRARÁ SI RECIBE PRINT
            this.txtMensaje.Text = e.Message;

        }

        private void btnInsertDept_Click(object sender, EventArgs e)
        {
            this.txtMensaje.Text = "";

            String sql = "INSERTDEPT";

            //com.Parameters,AddWithValue("","") delcara y añade sin poner el sqlparameter .dbtype= para el tipo

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@NUM";
            param.Value = this.txtNum.Text;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@NOM";
            param2.Value = this.txtNombre.Text;

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@LOC";
            param3.Value = this.txtxCity.Text;

            this.com.Parameters.Add(param);
            this.com.Parameters.Add(param2);
            this.com.Parameters.Add(param3);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            int afectadas = this.com.ExecuteNonQuery();

            this.cn.Close();

            CargarDept();
            this.com.Parameters.Clear();
            MessageBox.Show("Filas afectadas " + afectadas);

            this.txtxCity.Text = "";
            this.txtNombre.Text = "";
            this.txtNum.Text = "";
        }

        private void CargarDept() {
            
            String sql = "select * from dept";

            this.lstDept.Items.Clear();

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {
                String num = this.reader["DEPT_NO"].ToString();
                String nombre = this.reader["DNOMBRE"].ToString();
                String loc = this.reader["LOC"].ToString();
                this.lstDept.Items.Add(num + " -- " + nombre + " -- " + loc);
            }

            this.cn.Close();
            this.reader.Close();
        
        }
    }
}
