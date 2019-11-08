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
    public partial class Form23tablaMulti : Form
    {
        public Form23tablaMulti()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text.ToString());
            List<TextBox> cajas = new List<TextBox>();

            foreach (TextBox c in this.groupBox1.Controls) 
            {                
                cajas.Add(c);
            }
            cajas.Reverse();
            for (int i = 0; i < cajas.Count; i++)
            {                  
                cajas[i].Text = (num * (i + 1)).ToString();
            }
        }
    }
}
