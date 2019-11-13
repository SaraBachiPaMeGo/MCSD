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
        List<int> listaPremiados = new List<int>();
        public Form27Primitiva()
        {
            InitializeComponent();
            this.lstNumSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int posY = 0;
            int posX = 0;
            //Random alea = new Random();
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(40, 40);
                btn.Location = new Point(posX, posY);
                //int num = alea.Next(1, 20);                
                btn.Text = i.ToString();
                //this.aBtn.Add(btn);
                this.panelNum.Controls.Add(btn);
                btn.Click += Btn_Click;
                // posY += 40;
                posX += 40;
                if (i % 4 == 0)
                {
                    posY += 40;
                    posX = 0;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            String num = ((Button)sender).Text;
            if (!this.aBtn.Contains((Button)sender))
            {
                this.aBtn.Add(((Button)sender));
                if (this.lstNumSelect.Items.Count != 7 && this.aBtn.Count != 7)
                {
                    this.lstNumSelect.Items.Add(num);
                    ((Button)sender).BackColor = Color.Yellow;
                }
                else
                {
                    MessageBox.Show("No se pueden elegir más de 6 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.aBtn.Remove((Button)sender);
                this.lstNumSelect.Items.RemoveAt(this.lstNumSelect.Items.Count - 1);
                //Si deselecciona otro número que no sea el último, se borrará elúltimo
                // y se repetirá el número
                ((Button)sender).BackColor = Color.Empty;

            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int premio = alea.Next(1, 20);
                listaPremiados.Add(premio);
                if (listaPremiados.Contains(premio))
                {
                    listaPremiados.Remove(premio);
                    int premioNoRepetido = alea.Next(1, 20);
                    listaPremiados.Add(premioNoRepetido);
                }
            }

            foreach (Button btn in this.panelNum.Controls)
            {
                int numeroBoton = int.Parse(btn.Text);
                if (listaPremiados.Contains(numeroBoton) && btn.BackColor != Color.Yellow)
                {
                    btn.BackColor = Color.LightGreen;
                }
                else if (btn.BackColor == Color.Yellow && !listaPremiados.Contains(numeroBoton))
                {
                    btn.BackColor = Color.Red;
                }
                else if (btn.BackColor == Color.Yellow && listaPremiados.Contains(numeroBoton))
                {
                    btn.BackColor = Color.Yellow;
                }
            }

            { //foreach (Button numeroSeleccionado in this.aBtn) {
              //    int numSelect = int.Parse(numeroSeleccionado.Text);
              //    if (listaPremiados.Contains(numSelect))
              //    {
              //        for (int i = 0; i <= this.aBtn.Count - 1; i++) {
              //            //int seleccionar = int.Parse()
              //            this.lstNumSelect.SetSelected(i, true);
              //        }

                //    }
                //}
            }
            for (int i = 0; i <= this.aBtn.Count - 1; i++)
            {

                int numeroBoton = int.Parse(this.aBtn[i].Text);
                if (listaPremiados.Contains(numeroBoton))
                {
                    int indice = i;
                    this.lstNumSelect.SetSelected(i, true);
                }
            }

        }
    }
}