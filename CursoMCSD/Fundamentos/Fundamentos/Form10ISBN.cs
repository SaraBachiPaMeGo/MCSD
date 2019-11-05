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
    public partial class Form10ISBN : Form
    {
        public Form10ISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String isbn = this.txtISBN.Text;

            if (isbn.Length != 10) {
                this.txtResult.Text = "El ISBN introducido no tiene 10 caracteres";
            }
            int suma=0;
            for (int i = 0; i < isbn.Length ; i++) {
                //CONVERTIR UN CHAR A INT
                //CUANDO CONVERTIMOS UN CHAR A INT
                //DE FORMA CASTING, NOS DEVUELVE EL CODIGO ASCII DEL CHAR
                //int num = (int) isbn[i];
                int num = int.Parse(isbn[i].ToString()); // LO TENEMOS QUE HACER ASÍ PARA QUE NO NOS DE EL ASCII
                int car = (int)num * (i+1);
                suma += car;
                this.txtResult.Text += "\n " + isbn[i].ToString() + " * " + (i+1).ToString()
                    + " = "+ suma ; 
            }

            if (suma % 11 == 0)
            {
                this.txtResult.Text = "ISBN correcto";
            }
            else
            {
                this.txtResult.Text = "ISBN INCORRECTO";
            }

        }
    }
}
