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

    //ALTER PROCEDURE ELIMINARENF
    //(@INSC INT)
    //AS
    //    DELETE FROM ENFERMO

    //    WHERE INSCRIPCION = @INSC
    //GO

    //-------------------------------

    //ALTER PROCEDURE CARGARENF
    //AS

    //SELECT* FROM ENFERMO
    //GO


#endregion

namespace ProyectoAdo
{
    //Crear 2: procedimiento para que nos salgan todos los enfermos al ppio
    // le pasaremos como parámetro la insc y le borramos
    public partial class Form06EliminarEnfParam : Form
    {
        String cadena;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        List<int> listaIncript = new List<int>();

        public Form06EliminarEnfParam()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(this.cadena);
            this.com = new SqlCommand();

            CargarEnfermos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

                String sql = "ELIMINARENF";

                SqlParameter param = new SqlParameter();// ("@INSC",indice)
                param.ParameterName = "@INSC";
                param.Value = this.txtInscrip.Text;

                this.com.Parameters.Add(param);

                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;

                this.cn.Open();

                int afectados = this.com.ExecuteNonQuery();

                this.cn.Close();
                this.com.Parameters.Clear();

                CargarEnfermos();
                this.txtInscrip.Text = "";
                MessageBox.Show("Número de afectados" + afectados);
        }

        private void CargarEnfermos() {
            this.lstEnfermos.Items.Clear();
            this.listaIncript.Clear();

            String sql = "CARGARENF";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {
                String apellido = this.reader["APELLIDO"].ToString();
                String insc = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(apellido + " " + insc);
                this.listaIncript.Add(int.Parse(insc));
            }

            this.cn.Close();
            this.reader.Close();
        }

        private void lstEnfermos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelec = this.lstEnfermos.SelectedIndex;

            if (indiceSelec != -1) { 
                this.txtInscrip.Text = listaIncript[indiceSelec].ToString();
            }

        }
    }
}
