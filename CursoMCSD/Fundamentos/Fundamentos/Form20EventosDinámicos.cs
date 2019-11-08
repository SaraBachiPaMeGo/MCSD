using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form20EventosDinámicos : Form
    {
        public Form20EventosDinámicos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                //ASOCIAMOS EVENTOS +=
                //this.button1.Click += MostrarMensaje; // Si dejamos esto hace pila de llamadas
                foreach (Control c in this.Controls) {
                    if (c is Button)
                    {
                        c.Click += MostrarMensaje;
                    }
                }
                this.txtResult.Text = "Con eventos";
            }
            else {
                //DESASOCIAMOS EL EVENTO
                //   this.button1.Click -= MostrarMensaje;
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.Click -= MostrarMensaje;
                    }
                }
                this.txtResult.Text = "Sin eventos";
            }
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            //MessageBox.Show("Botón pulsado " + sender.ToString());
            ((Control)sender).BackColor = Color.LightGreen;
            Button btn = (Button) sender;
            btn.Text = "Soy verde";
        }
    }
}
