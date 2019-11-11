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
    public partial class Form26ControlesEnEjecuccion : Form
    {
        public Form26ControlesEnEjecuccion()
        {
            InitializeComponent();
        }       

        private void Btn_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Falta código
            Form26NumDialog f1 = new Form26NumDialog();
            DialogResult respuesta =
                f1.ShowDialog();
            //int numerocontroles = 5;
            if (respuesta == DialogResult.OK)
            {
              //  numerocontroles = f1.Numero;
            }


            int posicionY = 10;
            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Location = new Point(10, posicionY);
                btn.Size = new Size(30, 30);
                btn.BackColor = Color.Beige;
                btn.Click += Btn_Click;
                this.panel1.Controls.Add(btn);
                posicionY += 30;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //CULAQUIER DIALOG (Form modal) DEVUELVE UNA RESPUESTA
            //Y UN VALOR
            ColorDialog fcolor = new ColorDialog();
            DialogResult resp = fcolor.ShowDialog();
            Color color = Color.Empty;
            Font fuente = null;
            //Si la respuesta es positiva "Ok" sino "Cancel"
            if (resp == DialogResult.OK) {
                color = fcolor.Color;
            }
            FontDialog ffont = new FontDialog();//Devuelve una fuente
            resp = ffont.ShowDialog();

            if (resp == DialogResult.OK)
            {
                fuente = ffont.Font;
            }
            foreach (Button btn in this.panel1.Controls) {
                btn.BackColor = color;
                btn.Font = fuente;
            }
        }
    }
}
