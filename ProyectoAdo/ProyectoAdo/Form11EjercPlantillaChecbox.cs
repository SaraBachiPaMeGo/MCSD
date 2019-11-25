using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAdo.Datos;

namespace ProyectoAdo
{
    public partial class Form11EjercPlantillaChecbox : Form
    {
        Class11Datos datos; 
        public Form11EjercPlantillaChecbox()
        {
            InitializeComponent();

            datos = new Class11Datos();

            List<Hospital> listaHospi = datos.ListarHospital();
            List<int> listacod_hospital = new List<int>();
            int y = 0;
            foreach (Hospital hospi in listaHospi) {
                CheckBox chk = new CheckBox();
                y+=3;
                chk.Location = new Point(2,y);
                chk.Text = hospi.NombreHospi;
                chk.Tag = hospi.Cod_Hospi;//TAG 
                listacod_hospital.Add(hospi.Cod_Hospi);

                chk.Click += Chk_Click;

                this.panelCheck.Controls.Add(chk);
            }
        }

        private void Chk_Click(object sender, EventArgs e)
        {
            CheckBox ck= (CheckBox)sender;
            int cod_hospital = int.Parse(ck.Tag.ToString());
            List<Plantilla> listaPlantilla = datos.ListarPlantilla(cod_hospital);

            foreach (Plantilla plant in listaPlantilla) {
                ListViewItem it = new ListViewItem();
                it.Text = plant.Apellido.ToString();
                it.SubItems.Add(plant.Funcion.ToString());
                it.SubItems.Add(plant.Salario.ToString());
                this.listView1.Items.Add(it);
            }
        }
    }
}
