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
    public partial class Form01PrimerConectado : Form
    {
        String cadenaConnection;
        // Añadir si o si using System.Data.SqlClient; 
        SqlConnection cn; // dependerá de qué soport tengas en la bbdd
        SqlCommand com;
        SqlDataReader reader;
        public Form01PrimerConectado()
        {
            InitializeComponent();
            this.cadenaConnection = "Data Source=LOCALHOST;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Password=MCSD2019";            
            this.cn = new SqlConnection(this.cadenaConnection);
            this.com = new SqlCommand();
            // reader es una clase que no se puede instanciar
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.txtConnection.Text = "Conexión pasando de "+ e.OriginalState +" a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // LA CADENA DE CONEXION NUNCA AQUÍ, SINO EN EL CONSTRUCTOR DE SQL CONNECTION
            if (this.cn.State == ConnectionState.Closed)
            { 
                this.cn.Open(); // Habrá que meterlo en un if para que no nos de error si onectamos dos veces
                // tenemos que cercionarnos de que ya está abierta
            }            
            this.txtConnection.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.txtConnection.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //Indicar la conexión
            this.com.Connection = this.cn;
            // Indicar tipo de consulta 
            this.com.CommandType = CommandType.Text;
            // Indicar la consulta SQL 
            this.com.CommandText = "SELECT * FROM EMP";
            // Ejecutar la consulta --> OBJETO READER INSTANCIARLO ASÍ
            this.reader = this.com.ExecuteReader();

            // Leemos datos de la consulta

            for (int i = 0; i< this.reader.FieldCount; i++)
            {

                String columna = this.reader.GetName(i); // El nombre de la Columna que queremos recuperar -- > indice getname
                String tipo = this.reader.GetDataTypeName(i);
                this.lstColumn.Items.Add(columna);
                this.lstTipos.Items.Add(tipo);

            }

            //Leemos datos de un registro

            while (this.reader.Read())
            {

                String apellido = this.reader["APELLIDO"].ToString(); // getString -- getInt nos obliga a saber la posicion de la columna
                 // y el tipo de dato. GetValue() nos devuelve un objeto
                 // Debemos indicar qué registro queremos con this.reader.read() --> Leeremos un registro 
                 // columnas con un for (simpre empiezan por 0 ) y registros con un while

                this.lstApell.Items.Add(apellido);

            }

            // SIEMPRE CERRAR EL LECTOR PARAPODER REUTILIZARLO
            this.reader.Close();
        }
    }
}
