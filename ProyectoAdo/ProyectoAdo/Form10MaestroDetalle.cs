using ProyectoAdo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdo
{
    public partial class Form10MaestroDetalle : Form
    {
        Class10Datos datos;
        public Form10MaestroDetalle()
        {
            InitializeComponent();
            datos = new Class10Datos();
            
            //DEPARTAMENTOS

            List<Departamento> listaDept = datos.GetDepartamentos();

            foreach(Departamento dept in listaDept) {
                ListViewItem it = new ListViewItem();

                it.Text = dept.NombreDept;
                it.SubItems.Add(dept.LocDept);
                it.SubItems.Add(dept.NumeroDept.ToString());

                this.listDept.Items.Add(it);
            }

            //EMPLEADOS

            List<Empleado> listaEmp = datos.GetEmpleado();
            PintarEmpleados(listaEmp);           

            #region Explicación
            //Departamento dep = new Departamento();

            //dep.NumeroDept = 34;
            //dep.NombreDept = "LABORATORIO";
            //dep.LocDept = "Extremadura";

            ////Se utiliza un objeto listViewItem
            //// El texto es el elemento ppal y para cada columna siguiente
            //// se utiliza su colección subitems
            //ListViewItem listview = new ListViewItem();
            //listview.Text = dep.NumeroDept.ToString();
            //listview.SubItems.Add(dep.NombreDept);
            //listview.SubItems.Add(dep.LocDept);

            ////Añadimos el item al listview
            //this.listDept.Items.Add(listview);
            #endregion

        }

        private void listDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hay que hacer un if para seleccionar y deseleccionar
            // da error porque cuando seleccionamos otro, tiene primero que 
            //deseleccionar el que está seleccionado y segundo seleccionar el indicado
            if (this.listDept.SelectedItems.Count != 0)
            {
                int index = this.listDept.SelectedIndices[0]; // No tiene selectedIndex, tenemos que coger el seleccionado

                //Necesitamos el item seleccionado 
                ListViewItem itselect = this.listDept.SelectedItems[0];
                String dato = itselect.SubItems[2].Text;
                //this.label4.Text = dato;
                
                List<Empleado> listaEmp = datos.BuscarEmp(int.Parse(dato));
                PintarEmpleados(listaEmp);
               
            }
        }

        private void PintarEmpleados(List<Empleado> empleados) {
            this.listEmp.Items.Clear();

            foreach (Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();

                it.Text = emp.Num_Dept.ToString();
                it.SubItems.Add(emp.Apellido.ToString());
                it.SubItems.Add(emp.Salario.ToString());
                it.SubItems.Add(emp.Oficio.ToString());

                this.listEmp.Items.Add(it);
            }
        }
    }
}
