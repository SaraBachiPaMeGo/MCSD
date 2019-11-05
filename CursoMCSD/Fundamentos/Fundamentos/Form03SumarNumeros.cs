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
    public partial class Form03SumarNumeros : Form
    {
        public Form03SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(this.txtNum1.Text);
            n2 = int.Parse(this.txtNum2.Text);
            int suma = n2 + n1;
            //suma.ToString() = this.txtResul.Text;
            //Un método no se puede igualar
            this.txtResul.Text = suma.ToString();

        }
    }
}
