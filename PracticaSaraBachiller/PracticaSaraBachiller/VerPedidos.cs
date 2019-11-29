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
    public partial class VerPedidos : Form
    {
        ClassDatos datos;
        public VerPedidos()
        {
            InitializeComponent();
            datos = new ClassDatos();
            
            PintarPedidos();
            //PintarPedidosCli();
        }

        public void PintarPedidos()
        {
            this.listView1.Items.Clear();
            List<Pedido> listaPedi = datos.GetPedidos();

            foreach (Pedido pedi in listaPedi)
            {
                ListViewItem it = new ListViewItem();
                it.Text = pedi.codigoPedido.ToString();
                it.SubItems.Add(pedi.codigoCliente.ToString());
                it.SubItems.Add(pedi.fechaPedido.ToString());
                it.SubItems.Add(pedi.codigoProducto.ToString());
                it.SubItems.Add(pedi.unidades.ToString());
                this.listView1.Items.Add(it);
            }
        }

        public void PintarPedidosCli()
        {
            this.listView2.Items.Clear();
            ClientePedido cliPedi = datos.GetDetalles();

            //foreach (ClientePedido pedi in listaPediCli)
            //{
                ListViewItem it = new ListViewItem();
                it.Text = cliPedi.nombreProducto.ToString();
                it.SubItems.Add(cliPedi.precio.ToString());
                it.SubItems.Add(cliPedi.precioTotal.ToString());
                it.SubItems.Add(cliPedi.cantidad.ToString());
                it.SubItems.Add(cliPedi.fechaPedido.ToString());
                this.listView2.Items.Add(it);
            //}
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            datos.InsertPedidos(txtIdPedi.Text, txtIdClient.Text,
                Convert.ToDateTime(txtFecha.Text), int.Parse(txtIdProd.Text),
                int.Parse(txtUnid.Text));
            PintarPedidos();
            LimpiarCajas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            datos.DeletePedidos(txtIdPedi.Text, txtIdClient.Text,
                Convert.ToDateTime(txtFecha.Text), int.Parse(txtIdProd.Text),
                int.Parse(txtUnid.Text));
            PintarPedidos();
            LimpiarCajas();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                ListViewItem itSelect = this.listView1.SelectedItems[0];

                this.txtIdPedi.Text = itSelect.Text;
                this.txtIdClient.Text = itSelect.SubItems[1].Text;
                this.txtFecha.Text = itSelect.SubItems[2].Text;
                this.txtIdProd.Text = itSelect.SubItems[3].Text;
                this.txtUnid.Text = itSelect.SubItems[4].Text;
            }
            PintarPedidosCli();
        }

        private void LimpiarCajas()
        {
            txtIdProd.Text = "";
            txtFecha.Text = "";
            txtIdClient.Text = "";
            txtIdPedi.Text = "";
            txtUnid.Text = "";

        }
    }
}
