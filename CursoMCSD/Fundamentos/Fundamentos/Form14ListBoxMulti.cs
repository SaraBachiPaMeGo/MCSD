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
    public partial class Form14ListBoxMulti : Form
    {
        public Form14ListBoxMulti()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String dato = this.txtInput.Text.ToString();
            this.lstElement.Items.Add(dato);
            this.txtInput.Focus();
            this.txtInput.SelectAll();
        }
        //RECORRER
        private void button1_Click(object sender, EventArgs e)
        {
            String indices = "";
            String elementos = "";
            //Recorremos los índices seleccionados

            foreach (int ind in this.lstElement.SelectedIndices) {
                indices += ind + ",";
            }
            //Recorremos todos los elementos seleccionados
            foreach (Object obj in this.lstElement.SelectedItems) {
                elementos += obj + ",";
            }

            this.lblPositions.Text = indices;
            this.lblSelects.Text = elementos; 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int indice = this.lstElement.SelectedIndex;
            //this.lstElement.Items.RemoveAt(indice);
           //int indices = 0;
            //foreach (int indice in this.lstElement.SelectedIndices) {
            //   indices += indice; 
            //  
            //    //siempre hay que eliminar de abajo a arriba, para
            //    // que no afecte a la posición de los de detrás

            //}
            int numSelect = this.lstElement.SelectedIndices.Count- 1;
            //count num de elementos, es igual que length pero en la colección
            for (int i = numSelect; i >= 0; i--){
                int indice = this.lstElement.SelectedIndices[i];
                this.lstElement.Items.RemoveAt(indice);
            }
            
        }
    }

}
