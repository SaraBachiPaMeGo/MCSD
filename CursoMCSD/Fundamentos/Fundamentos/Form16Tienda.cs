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
    public partial class Form16Tienda : Form
    {
        public Form16Tienda()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            String product = this.txtProduct.Text;
            
            //Preguntar si exite en la colección
            if (this.listTienda.Items.Count == 0) {
                this.listTienda.Items.Add(product);
                this.txtProduct.Text = "";
            } 
            else if (!this.listTienda.Items.Contains(product))
            {
                this.listTienda.Items.Add(product);
                this.txtProduct.Text = "";
            }
            else 
            {
                //foreach (String item in this.listTienda.Items) {
                    //if (item == product) {
                int seleccionar =  this.listTienda.Items.IndexOf(product);
                this.listTienda.SetSelected(seleccionar, true);
                this.txtProduct.Text = "";
            }
                //}
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Coger el elemento seleccionado
            int indice = this.listTienda.SelectedIndex;
            this.listTienda.Items[indice] = this.txtProduct.Text;            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = this.listTienda.SelectedIndices.Count - 1; i >= 0; i--) {
            
                int indice = this.listTienda.SelectedIndices[i];
                this.listTienda.Items.RemoveAt(indice);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //foreach(Object item in this.listTienda.Items) { 
            //this.listTienda.Items.Remove(item);
            //}
            this.listTienda.Items.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             for (int i = this.listTienda.SelectedIndices.Count - 1; i >= 0; i--) 
            //for (int i = 0; i <= this.listTienda.SelectedIndices.Count; i++)
            {
                int item = this.listTienda.SelectedIndices[i];
                this.listAlmac.Items.Add(this.listTienda.Items[item]);
                this.listTienda.Items.RemoveAt(int.Parse(item.ToString()));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (object item in this.listTienda.Items) {
                this.listAlmac.Items.Add(item);                
            }
            this.listTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.listAlmac.SelectedIndex != 0)
            {
                this.btnSubir.Enabled = true;
                int item = this.listAlmac.SelectedIndex;
                Object product = this.listAlmac.Items[item];
                this.listAlmac.Items.RemoveAt(item);
                //Guardar el primer indice, coger el nuevo, restárselo y el resultado será la posición actual 
                //que ocupará
                //this.listAlmac.Items.Add(product);
                //int ultimoIndice = this.listAlmac.Items.Count;
                int ult = item - 1;
                this.listAlmac.Items.Insert(ult, product);
                //Ponemos el foco 
                this.listAlmac.SelectedIndex = ult;
            }
            else
            {
                this.btnSubir.Enabled = false;
            }

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.listAlmac.SelectedIndex != this.listAlmac.Items.Count)
            {
                int item = this.listAlmac.SelectedIndex;
                Object product = this.listAlmac.Items[item];
                this.listAlmac.Items.RemoveAt(item);
                int ult = item + 1;
                this.listAlmac.Items.Insert(ult, product);
                this.listAlmac.SelectedIndex = ult;
            }
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter) {
                
                this.listTienda.Items.Add(this.txtProduct.Text);
            }
        }
    }
}
