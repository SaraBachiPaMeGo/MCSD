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
    public partial class Form05PracticaNum : Form
    {
        public Form05PracticaNum()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = int.Parse(this.txtNum1.Text);
            n2 = int.Parse(this.txtNum2.Text);
            n3 = int.Parse(this.txtNum3.Text);

            String mensaje;

            if (n1>n2 && n2>n3) {
                mensaje = n1 + " es mayor que " + n2 + " y éste a su vez, mayor que " + n3;
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } 
            else if (n2 > n1 && n1 > n3) {
                mensaje = n2 + " es mayor que " + n1 + " y éste a su vez, mayor que " + n3;
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else if (n3 > n2 && n2 > n1) {
                mensaje = n3 + " es mayor que " + n2 + " y éste a su vez, mayor que " + n1;
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (n3 > n1 && n1 > n2)
            {
                mensaje = n3 + " es mayor que " + n1 + " y éste a su vez, mayor que " + n2;
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (n1 > n3 && n3 > n2)
            {
                mensaje = n1 + " es mayor que " + n3 + " y éste a su vez, mayor que " + n2;
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                mensaje = "Todos los números son iguales";
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
