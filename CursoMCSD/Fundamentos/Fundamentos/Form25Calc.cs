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
    public partial class Form25Calc : Form
    {
        String numero = "";
        String simb = "";
        public Form25Calc()
        {
            InitializeComponent();
            foreach (Button btn in this.panelNum.Controls) {
                btn.Click += BtnNum_Click;
            }

            foreach (Button btn in this.panelSimb.Controls)
            {
                btn.Click += BtnSimb_Click;
            }
        }

        private void BtnSimb_Click(object sender, EventArgs e)
        {
            numero = this.txtResult.Text;
            simb = ((Button)sender).Text;
            this.txtResult.Text = "";             
        }
        private void btnResult_Click(object sender, EventArgs e)
        {            
            switch (simb)
            {
                case "/":
                    Dividir();
                    break;
                case "*":
                    Multiplicar();
                    break;
                case "+":
                    Sumar();
                    break;
                case "-":
                    Restar();
                    break;
            }
        }
        void Dividir() {
            if (this.txtResult.Text == "0") {
                MessageBox.Show("No se puede dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtResult.Text =  (int.Parse(numero) / int.Parse(this.txtResult.Text)).ToString();
            }
        }
        void Multiplicar()
        {
            this.txtResult.Text = (int.Parse(numero) * int.Parse(this.txtResult.Text)).ToString();
        }
        void Sumar()
        {
            this.txtResult.Text = (int.Parse(numero) + int.Parse(this.txtResult.Text)).ToString();
        }
        void Restar()
        {
            this.txtResult.Text = (int.Parse(numero) - int.Parse(this.txtResult.Text)).ToString();
        }
        private void BtnNum_Click(object sender, EventArgs e)
        {            
            String num = ((Button)sender).Text;
            this.txtResult.Text += num;
            //this.lblPRUEBA.Text = numero; 
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Clear();
             numero = "";
             simb = "";
        }
    }
}
