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
    public partial class Form15PracticaNum : Form
    {
        public Form15PracticaNum()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int aleatorio = random.Next(NUMERO INICIAL, NUMERO FINAL);

            Random random = new Random();
            int num = 0;
            for (int i = 1; i <= 30; i++) {
                 num = random.Next(1, 30);              
                this.listNum.Items.Add(num.ToString());
            }          
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaPar = 0;
            int sumaImpar = 0;

            if (radioAll.Checked)
            {
                 foreach (String item in this.listNum.Items) {
                    //CONVERTIR CADA ITEM A INT
                    //item
                    //CONVERTIR UN STRING A INT
                    int num = int.Parse(item);
                    int item2 = num;
                    if (item2 % 2 == 0)
                    {
                        sumaPar += num;
                        this.txtPar.Text = sumaPar.ToString();
                    }
                    else {
                        sumaImpar += num;
                        this.txtImpar.Text = sumaImpar.ToString();
                    }
                    this.txtSuma.Text = (sumaPar + sumaImpar).ToString();

                 }
            }
            else if (radioSelect.Checked) {
                foreach (String obj in this.listNum.SelectedItems) {
                    int num = int.Parse(obj);
                    int item2 = num;
                    if (item2 % 2 == 0)
                    {
                        sumaPar += num;
                        this.txtPar.Text = sumaPar.ToString();
                    }
                    else
                    {
                        sumaImpar += num;
                        this.txtImpar.Text = sumaImpar.ToString();
                    }
                    this.txtSuma.Text = (sumaPar + sumaImpar).ToString();
                }
            }
        }
    }
}
