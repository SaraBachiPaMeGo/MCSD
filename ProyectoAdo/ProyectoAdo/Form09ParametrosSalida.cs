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
using System.Configuration;

#region PROCEDIMIENTOS ALMACENADOS
//CREATE PROCEDURE DEPART
//AS

//    SELECT* FROM DEPT
//GO

//ALTER PROCEDURE EMPLEADO
//(@DEPT_NUM INT, @SUMA INT OUT, @MEDIA INT OUT) -- VALORES QUE VAMOS A DEVOLVER
//AS

//    SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO) FROM EMP

//    WHERE DEPT_NO = @DEPT_NUM

//    SELECT* FROM EMP
//   WHERE DEPT_NO = @DEPT_NUM
//GO
#endregion

namespace ProyectoAdo
{
    public partial class Form09ParametrosSalida : Form
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        List<int> departamentos;
        public Form09ParametrosSalida()
        {
            InitializeComponent();
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            // Las cadenas de conexión deben incluir dentro del config de la App 
            // Un config es un fichero XML que puede almacenar elementos de la configuración de la App.
            String colorLetra = ConfigurationManager.AppSettings["colorletra"];
            this.ForeColor = Color.FromName(colorLetra);
            this.cn = new SqlConnection(this.cadena);
            this.com = new SqlCommand();
            this.departamentos = new List<int>();

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "DEPART";

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {
                String nombre = this.reader["DNOMBRE"].ToString();
                int num = int.Parse(this.reader["DEPT_NO"].ToString());
                this.cmdDepart.Items.Add(nombre);
                this.departamentos.Add(num);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void cmdDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDepar = this.cmdDepart.SelectedIndex;
            int detp_no = this.departamentos[indexDepar];

            //this.com.Parameters.AddWithValue("@DEPT_NUM", detp_no);
            SqlParameter param = new SqlParameter("@DEPT_NUM", detp_no);
            this.com.Parameters.Add(param);

            //OBJETO PARAMETER PARA QUE NOS DEVUELVA LOS OUT DEL PROCEDURE
            SqlParameter paramSum = new SqlParameter();
            paramSum.ParameterName = "@SUMA";
            paramSum.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSum);

            SqlParameter paramMedia = new SqlParameter();
            paramMedia.ParameterName = "@MEDIA";
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "EMPLEADO";

            //Los parámetros sean de entrada o salida tienen que tener un valor por defecto
            paramSum.Value = 0;
            paramMedia.Value = 0;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            

            this.lstEmp.Items.Clear();

            while (this.reader.Read()) {
                String apellido = this.reader["APELLIDO"].ToString();
                this.lstEmp.Items.Add(apellido);
            }

            //Los parámetros de salida solmanete se capturarán cuando cerremos el reader
            this.reader.Close();

            //CAPTURAMOS EL VALOR DE LOS PARÁMETROS DE SALIDA
            this.txtSum.Text = paramSum.Value.ToString() ;
            this.txtMedia.Text = paramMedia.Value.ToString() ;

            //this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
