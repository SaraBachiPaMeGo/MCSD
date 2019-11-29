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
    public partial class Form1 : Form
    {
        ContextoHospitalDataContext context ;
        public Form1()
        {
            InitializeComponent();
            String cadena = ConfigurationManager.ConnectionStrings["conexiontajamar"].ConnectionString;
            context = new ContextoHospitalDataContext(cadena);
        }

        private void btnMostrarDept_Click(object sender, EventArgs e)
        {
            // Las consultas linq se almacenan en variables de tipo genérico
            // llamadas var (se adaptan al objeto que venga en su interior)
            // Solamente podemos declarar este tipo de variables a nivel de 
            // método.
            // HAY QUE INSTANCIAR LA CLASE / OBJETO DE ACCESO A DATOS 
            // QUE ES NUESTRO DATACONTEXT
            // El nombre del obj siempre será nombreArchivoDataContext
            //ContextoHospitalDataContext context = new ContextoHospitalDataContext();
            //Se puede introducir cadena de la conexión en ContextoHospitalDataContext(cadena)

            var consulta = from datos in context.DEPTs select datos;
            

            foreach (DEPT dept in consulta) {
                ListViewItem it = new ListViewItem();
                it.Text = dept.DNOMBRE;
                it.SubItems.Add(dept.DEPT_NO.ToString());
                it.SubItems.Add(dept.LOC.ToString());
                this.listViewDept.Items.Add(it);
            }
        }

        private void btnMostrarEmp_Click(object sender, EventArgs e)
        {
            ListViewItem it = this.listViewDept.SelectedItems[0];
             int deptno = int.Parse(it.SubItems[1].Text);
            var consulta2 = from datos in context.EMPs where datos.DEPT_NO == deptno
                            select new { datos.APELLIDO };

            this.listBoxEmpleados.Items.Clear();

            foreach (var emp in consulta2) // Si cogemos un objeto anónimo hay que
                // utilizar la variable var 
            {
                this.listBoxEmpleados.Items.Add(emp.APELLIDO);
            }

        }       
    }
}
