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
    public partial class Form3Clientes : Form
    {
        String cadena;
        ContextoTiendaDataContext context;
        public Form3Clientes()
        {
            InitializeComponent();
            this.cadena = ConfigurationManager.ConnectionStrings["conexiontienda"].ConnectionString;
            context = new ContextoTiendaDataContext();
            PintarEmpleados();
        }
        public void PintarEmpleados() {
            var consulta = from datos in context.Clientes
                           select new
                           {
                               datos.CodigoCliente,
                               datos.Contacto,
                               datos.Empresa,
                               datos.Cargo,
                               datos.Ciudad
                           };
            this.treeView1.Nodes.Clear();
            TreeNode raiz = new TreeNode();
            
            this.treeView1.Nodes.Add(raiz);

            foreach (var emp in consulta) 
            {
                raiz.Text = "EMPLEADO";
                raiz.Nodes.Add(emp.CodigoCliente);
                raiz.Nodes.Add(emp.Contacto);
                TreeNode nodoemp = new TreeNode();
                nodoemp.Text = "DETALLES DE EMPLEADO";
                raiz.Nodes.Add(nodoemp);
                TreeNode nodoemp1 = new TreeNode();
                nodoemp1.Nodes.Add(emp.Cargo);
                nodoemp1.Nodes.Add(emp.Ciudad);
                raiz.Nodes.Add(nodoemp1);
                
            }
            
        }
    }
}
