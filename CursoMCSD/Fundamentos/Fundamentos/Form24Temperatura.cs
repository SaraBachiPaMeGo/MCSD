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
        List<int> temperaturas;
        public Form24Temperatura()
        {
            InitializeComponent();
                this.temperaturas = new List<int>();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int maxima = this.temperaturas[0];
            int min = this.temperaturas[0];
            //int compraracion =0; 
            //for (int i = 0; i < this.listaTemp.Items.Count - 1; i++)
            foreach(int temperatura in this.temperaturas)
            {
                //temperatura = int.Parse(this.listaTemp.Items[i].ToString());
                //comparacion = temperatura;
                
                //if (temperatura > comparacion) {
                //    this.txtMax.Text = temperatura.ToString();
                //}
                maxima = Math.Max(maxima, temperatura);
                min = Math.Min(min, temperatura);
                suma += temperatura;
            }
            int resultado = suma/ this.listaTemp.Items.Count;
            this.txtMedia.Text = resultado.ToString();
            this.txtMax.Text = maxima.ToString();
            this.txtMin.Text = min.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.listaTemp.Items.Clear();
            this.temperaturas.Clear();
            Random aleatorio = new Random();
            DateTime fecha = DateTime.Parse("01/01/2019");

            for (int i = 1; i <= 12; i++)
            {
                String mes = fecha.ToString("MMMM");
                int num = aleatorio.Next(-50, 50);
                this.listaTemp.Items.Add(mes.ToUpper() +" " + num);
                fecha = fecha.AddMonths(1);
                this.temperaturas.Add(num);
            }
        }
    }
}
