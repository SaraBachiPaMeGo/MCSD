using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form29Meses : Form
    {
        public Form29Meses()
        {
            InitializeComponent();
        }
        List<Mes> listaMeses = new List<Mes>();
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            Random alea = new Random();
            
            for (int i = 1; i <= 12; i++) {
                
                DateTime fecha =  DateTime.Parse("01/"+i+"/2019");
                String nombremes = fecha.ToString("MMMM");
                Mes mes = new Mes();
                mes.Nombre = nombremes;
                int num1 = alea.Next(-20, 40);
                int num2 = alea.Next(-20, 40);

                int max = Math.Max(num1, num2);
                int min = Math.Min(num1, num2);

                mes.Maximo = max;
                mes.Minimo = min;
                //mes.CalcularMedia(mes.Maximo, mes.Minimo);

                this.listaMeses.Add(mes);
                this.lstMeses.Items.Add(mes.Nombre);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.txtNombre.Text = this.lstMeses.SelectedItem.ToString();
            int indice = this.lstMeses.SelectedIndex;
            Mes obj =this.listaMeses[indice];
            this.txtMax.Text =(obj.Maximo).ToString();
            this.txtMin.Text =(obj.Minimo).ToString();
            this.txtMedia.Text = (obj.CalcularMedia(obj.Maximo,obj.Minimo)).ToString();
        }
    }
}
