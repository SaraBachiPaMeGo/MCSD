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
    public partial class Form22SumarNum : Form
    {
        public Form22SumarNum()
        {
            InitializeComponent();            
            
            Random aleatorio = new Random();

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                { 
                    c.Text = aleatorio.Next(1, 20).ToString();
                    c.Click += AñadirClick;
                }                
            }
        }

        private void AñadirClick(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Text);               
            int numCaja = int.Parse(this.txtReuslt.Text.ToString());
            int suma = numCaja + num;
            this.txtReuslt.Text = suma.ToString();
        }


    }
}
