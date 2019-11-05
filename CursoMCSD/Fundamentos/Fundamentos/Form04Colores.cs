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
    public partial class Form04Colores : Form
    {
        public Form04Colores()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red = int.Parse(this.txtRojo.Text);
            green = int.Parse(this.txtVerde.Text);
            blue = int.Parse(this.txtAzul.Text);

            this.BackColor = Color.FromArgb(red, green, blue);

            this.btnChange.Location = new Point(10, 10);
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            String msj;
            if (num > 0)
            {
                msj = "POSITIVO";
            }
            else if (num < 0) {
                msj = "NEGATIVO";
            }
            else {
                msj = "CERO";
            }

            //Dentro de c# tenemos métodos que contienen sobrecarga
            // varias formas de hacer lo mismo
            MessageBox.Show(msj,"Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //this.label8.Text = msj; Un objeto es null cuando no está creado 
            // y no se puede utilizar
            int numero = 2;
            switch (numero) {
                case 0:
                case 1:
                    msj = "VALOR 0 Ó 1";
                    break;
                case 2:
                    msj = "VALOR 2";
                    break;
                default:
                    msj = "DEFAULT";
                    break;

            }
        }
    }
}
