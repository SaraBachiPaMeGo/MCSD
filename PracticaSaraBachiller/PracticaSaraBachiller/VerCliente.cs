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
    public partial class VerCliente : Form
    {
        ClassDatos datos;
        public VerCliente()
        {
            InitializeComponent();
            datos = new ClassDatos();

            PintarClientes();

        }
        public void PintarClientes()
        {
            this.listView1.Items.Clear();
            List<Cliente> listaCli = datos.GetClientes();

            foreach (Cliente cli in listaCli)
            {
                ListViewItem it = new ListViewItem();
                it.Text = cli.codigoCliente.ToString();
                it.SubItems.Add(cli.empresa.ToString());
                it.SubItems.Add(cli.contacto.ToString());
                it.SubItems.Add(cli.cargo.ToString());
                it.SubItems.Add(cli.ciudad.ToString());
                it.SubItems.Add(cli.tlf.ToString());
                this.listView1.Items.Add(it);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            datos.UpdateCliente(txtIdCli.Text, txtEmpresa.Text,txtContacto.Text,txtCargo.Text,
                txtCity.Text, int.Parse(txtTlf.Text));
            PintarClientes();
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            txtCargo.Text = "";
            txtCity.Text = "";
            txtContacto.Text = "";
            txtEmpresa.Text = "";
            txtIdCli.Text = "";
            txtTlf.Text = "";
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (this.listView1.SelectedItems.Count != 0)
                {
                    ListViewItem itSelect = this.listView1.SelectedItems[0];

                    this.txtIdCli.Text = itSelect.Text;
                    this.txtEmpresa.Text = itSelect.SubItems[1].Text;
                    this.txtContacto.Text = itSelect.SubItems[2].Text;
                    this.txtCargo.Text = itSelect.SubItems[3].Text;
                    this.txtCity.Text = itSelect.SubItems[4].Text;
                this.txtTlf.Text = itSelect.SubItems[5].Text;
            }
            PintarClientes();
        }      
        
    }
}
