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

#region
//ALTER PROCEDURE CARGAREMP
//AS

//    SELECT APELLIDO, EMP_NO FROM EMP
//GO

//CREATE PROCEDURE BUSCAR_EMP
//(@NUM INT)
//AS
//    SELECT APELLIDO, SALARIO, COMISION FROM EMP
//    WHERE EMP_NO = @NUM
//GO

//ALTER TRIGGER ELIMINAR_EMP
//ON EMP
//INSTEAD OF DELETE
//AS
//    DECLARE @OFICIO NVARCHAR(10)

//    DECLARE @EMP_NO INT

//    SELECT @EMP_NO= EMP_NO FROM deleted

//    SELECT @OFICIO = OFICIO FROM DELETED
//    WHERE EMP_NO = @EMP_NO

//    IF(@OFICIO = 'PRESIDENTE')

//    BEGIN
//        PRINT 'NO SE PUEDE ELIMINAR AL PRESIDENTE'
//	END
//    ELSE

//    BEGIN
//        DELETE FROM EMP

//        WHERE EMP_NO = @EMP_NO

//    END
//GO

//EXEC ELIMINAR_EMP2 7499

//CREATE PROCEDURE ELIMINAR_EMP2
//(@NUM_EMP INT)
//AS
//    DELETE FROM EMP

//    WHERE EMP_NO = @NUM_EMP
//GO
#endregion

namespace ProyectoAdo
{
    public partial class Form08ModificarEmpTriggers : Form
    {
        SqlConnection cn;
        String cadena;
        SqlDataReader reader;
        SqlCommand com;
        List<int> listaEmp_no;
        public Form08ModificarEmpTriggers()
        {
            InitializeComponent();
            this.cadena = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.listaEmp_no = new List<int>();
            this.cn.InfoMessage += Cn_InfoMessage;

            CargarEmp();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.label9.Text = e.Message;
        }

        private void CargarEmp() {
            String sql = "CARGAREMP";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                String apellido = this.reader["APELLIDO"].ToString();
                int emp_no = int.Parse(this.reader["EMP_NO"].ToString());

                this.cmbEmp.Items.Add(apellido);
                this.listaEmp_no.Add(emp_no);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String sql = "MODIFICAR_EMP2";

            int indiceSleccionado = this.cmbEmp.SelectedIndex;

            SqlParameter paramNum = new SqlParameter("@EMP_NO", this.listaEmp_no[indiceSleccionado]);
            SqlParameter paramSal= new SqlParameter("@SALARIO", this.txtSalario.Text);
            SqlParameter paramCom = new SqlParameter("@COMISION", this.txtComi.Text);

            this.com.Parameters.Add(paramNum);
            this.com.Parameters.Add(paramSal);
            this.com.Parameters.Add(paramCom);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            int afectados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();

            CargarEmp();
            MessageBox.Show("Afectados: " + afectados);

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "ELIMINAR_EMP2";

            int indiceSleccionado = this.cmbEmp.SelectedIndex;

            SqlParameter param = new SqlParameter("@NUM_EMP", this.listaEmp_no[indiceSleccionado]);
            this.com.Parameters.Add(param);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            int afectados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();

            CargarEmp();
            MessageBox.Show("Afectados" + afectados);
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSleccionado = this.cmbEmp.SelectedIndex;

            String sql = "BUSCAR_EMP";

            SqlParameter param = new SqlParameter("@NUM", this.listaEmp_no[indiceSleccionado]);

            this.com.Parameters.Add(param);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();
            
            while (this.reader.Read()) {
                String apellido = this.reader["APELLIDO"].ToString();
                String salario = this.reader["SALARIO"].ToString();
                String comision = this.reader["COMISION"].ToString();


                this.txtApellido.Text = apellido;
                this.txtComi.Text = comision;
                this.txtSalario.Text = salario;
            }

            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INCREMENTAR SALARIO DEPARTAMENTO 
            String sql = "MODIFICAR_EMP";

            SqlParameter param = new SqlParameter("@INC", this.txtInc.Text);
            SqlParameter param2 = new SqlParameter("@dept_no", this.txtInc.Text);

            this.com.Parameters.Add(param);
            this.com.Parameters.Add(param2);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();

            int afectados = this.com.ExecuteNonQuery();
            MessageBox.Show("Afectados " + afectados);

        }
    }
}
