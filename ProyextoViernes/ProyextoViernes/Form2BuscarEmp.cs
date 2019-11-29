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

namespace ProyextoViernes
{
    public partial class Form2BuscarEmp : Form
    {
        String cadena;
        ContextoHospitalDataContext context;
        public Form2BuscarEmp()
        {
            InitializeComponent();
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            context = new ContextoHospitalDataContext();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var consulta = from datos in context.EMPs
                           where datos.APELLIDO.StartsWith(txtApe.Text) 
                           select new { 
                               Apellido =datos.APELLIDO,
                               SalarioAnual = datos.SALARIO* 14,
                               SalarioTotal = datos.SALARIO + datos.COMISION
                           };
            this.listViewEmp.Items.Clear();
            
            foreach (var emp in consulta) {
                ListViewItem it = new ListViewItem();
                it.Text = emp.Apellido;
                it.SubItems.Add(emp.SalarioAnual.ToString());
                it.SubItems.Add(emp.SalarioTotal.ToString());
                this.listViewEmp.Items.Add(it);
            }

            TreeNode raiz = new TreeNode();
            raiz.Text = "EMPLEADOS";
            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.Add(raiz);

            foreach (var emp in consulta)
            {
                TreeNode nodoemp = new TreeNode();
                nodoemp.Text = emp.Apellido;
                raiz.Nodes.Add(nodoemp);
            }
        }
    }
}
