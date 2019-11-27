using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdo
{
    public partial class Form15Vista : Form
    {
        public Form15Vista(String apellido, String oficio, int salario)
        {
            InitializeComponent();
            txtApellido.Text = apellido;
            txtTrabajo.Text = oficio;
            txtSalario.Text = salario.ToString() ;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
