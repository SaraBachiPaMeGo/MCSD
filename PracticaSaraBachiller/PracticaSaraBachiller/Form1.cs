using PracticaSaraBachiller.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSaraBachiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            VerProductos form1 = new VerProductos();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPedidos form2 = new VerPedidos();
            form2.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VerCliente form3 = new VerCliente();
            form3.Show();
        }
    }
}
