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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String dato = this.txtInput.Text.ToString();
            this.lstElement.Items.Add(dato);
            this.txtInput.Text = "";
        }

        private void lstElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Preguntamos si hay algún elemento seleccionado
            if (this.lstElement.SelectedIndex != -1) {
                this.lblPosition.Text = "Posición: " + this.lstElement.SelectedIndex;
                this.lblSelect.Text = "Elemento seleccionado: " + this.lstElement.SelectedItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indice = this.lstElement.SelectedIndex;
            this.lstElement.Items.RemoveAt(indice);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
           int indice = this.lstElement.SelectedIndex;
            this.lstElement.Items[indice] = this.txtInput.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Borramos toda la coleccion
            this.lstElement.Items.Clear();
        }

    }
}
