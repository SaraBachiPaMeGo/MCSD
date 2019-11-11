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
    public partial class Form27Primitiva : Form
    {
        List<Button> aBtn = new List<Button>();
        public Form27Primitiva()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int posY = 0;
            int posX = 0;
            //Random alea = new Random();
            for (int i = 1; i <= 20; i++) {
                Button btn = new Button();
                btn.Size = new Size(40,40);
                btn.Location = new Point(posX,posY);
                //int num = alea.Next(1, 20);                
                btn.Text = i.ToString();
                this.aBtn.Add(btn);
                this.panelNum.Controls.Add(btn);
                btn.Click += Btn_Click;
               // posY += 40;
                posX += 40;
                if (i% 4 ==0 ) {
                    posY += 40;
                    posX = 0;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
           String num = ((Button)sender).Text;
            if (this.lstNumSelect.Items.Count != 6 && this.aBtn.Count != 6)
            {
                this.lstNumSelect.Items.Add(num);
                ((Button)sender).BackColor = Color.Yellow;
            }
            else {
                MessageBox.Show("No se pueden elegir más de 6 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
           // List<int> premio = new List<int>();
            Random alea = new Random();
            List<int> num=new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                int numer = alea.Next(1, 20);
                num.Add(numer);
                this.label2.Text = "";
                foreach (int number in num)
                {
                this.label2.Text +="\n"+ numer.ToString();
                }
                    
            }  
                
            foreach (Button obj in this.aBtn) {
                int valorBoton = int.Parse(obj.Text);
                foreach (int number in num) { 
                    if (valorBoton == number) {
                        obj.BackColor = Color.LightGreen;
                        //this.lstNumSelect.Contains(num);
                    }
                    else /*if (!obj)*/
                    {
                        obj.BackColor = Color.Red;
                    }
                }
                
            }
        }
        
    }
}
