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
    public partial class Form08ClaseChar : Form
    {
        public Form08ClaseChar()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++) {
                char caract = (char) i;
                if (Char.IsNumber(caract))
                {
                    this.txtNum.Text += caract;
                }
                else if (Char.IsLetter(caract))
                {
                    this.txtletras.Text += caract;
                }
                else if (Char.IsSymbol(caract))
                {
                    this.txtSim.Text += caract;
                }
                else if (Char.IsPunctuation(caract)) {
                    this.txtPuntu.Text += caract;
                }
            }
        }
    }
}
