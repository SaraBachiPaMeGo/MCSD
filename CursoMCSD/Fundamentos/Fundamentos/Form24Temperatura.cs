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
    public partial class Form24Temperatura : Form
    {
        public Form24Temperatura()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int comparacion = 0;
            for (int i = 0; i < this.listaTemp.Items.Count - 1; i++)
            {
                int temperatura = int.Parse(this.listaTemp.Items[i].ToString());
                comparacion = temperatura;
                suma += temperatura;
                if (temperatura > comparacion) {
                    this.txtMax.Text = temperatura.ToString();
                }
            }
            int resultado = suma/ this.listaTemp.Items.Count;
            this.txtMedia.Text = resultado.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            for (int i = 1; i <= 8; i++)
            {
                int num = aleatorio.Next(-50, 50);
                this.listaTemp.Items.Add(num);
            }
        }
    }
}
