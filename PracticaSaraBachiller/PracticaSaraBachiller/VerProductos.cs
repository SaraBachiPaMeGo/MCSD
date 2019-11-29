using PracticaSaraBachiller.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSaraBachiller
{
    public partial class VerProductos : Form
    {
        ClassDatos datos;
        public VerProductos()
        {
            InitializeComponent();
            datos = new ClassDatos();

            PintarProductos();
        }

        public void PintarProductos() {

            this.listView1.Items.Clear();
            List<Producto> listaProd = datos.GetProductos();

            foreach (Producto prod in listaProd)
            {
                ListViewItem it = new ListViewItem();
                it.Text = prod.idProducto.ToString();
                it.SubItems.Add(prod.nombreProducto.ToString());
                it.SubItems.Add(prod.precioProducto.ToString());
                it.SubItems.Add(prod.StockProducto.ToString());
                this.listView1.Items.Add(it);
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            datos.InsertProductos(int.Parse(txtIdProd.Text),
                txtNombre.Text,int.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
            PintarProductos();
            LimpiarCajas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            datos.UpdateProductos(int.Parse(txtIdProd.Text),
                txtNombre.Text, int.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
            PintarProductos();
            LimpiarCajas();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0) {
                ListViewItem itSelect = this.listView1.SelectedItems[0];

                this.txtIdProd.Text = itSelect.Text;
                this.txtNombre.Text = itSelect.SubItems[1].Text;
                this.txtPrecio.Text = itSelect.SubItems[2].Text;
                this.txtStock.Text = itSelect.SubItems[3].Text;

            }
        }

        private void LimpiarCajas() {
            txtIdProd.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
    }
}
