using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAdo.Datos;

namespace ProyectoAdo
{
    public partial class Form13ClaseDatos : Form
    {
        Class13Datos datos;
        public Form13ClaseDatos()
        {
            InitializeComponent();
            //AQUI QUIERES LOS DEPARTAMENTOS??
            datos = new Class13Datos();
            PintarDep();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            datos.InsertarDep(int.Parse(txtNum.Text), txtNombre.Text, txtLoc.Text);
            PintarDep();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarDep(int.Parse(txtNum.Text.ToString()));
            PintarDep();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            datos.ModificarDep(int.Parse(txtNum.Text), txtNombre.Text, txtLoc.Text);
            PintarDep();

        }

        private void PintarDep() {
            this.lvsDep.Items.Clear();
            List<Departamento> listaDep = datos.CargarDepartamentos();

            foreach (Departamento dept in listaDep)
            {
                ListViewItem it = new ListViewItem();
                it.Text = dept.NombreDept.ToString();
                it.Tag = dept.NumeroDept;
                it.SubItems.Add(dept.LocDept.ToString());
                this.lvsDep.Items.Add(it);
            }
        }

        private void lvsDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvsDep.SelectedItems.Count !=0) {

                ListViewItem itSelec = this.lvsDep.SelectedItems[0];

                txtNombre.Text = itSelec.SubItems[0].Text;
                txtLoc.Text = itSelec.SubItems[1].Text;
                txtNum.Text = itSelec.Tag.ToString();
                label6.Text = itSelec.Tag.ToString();
            }
        }
    }
}
