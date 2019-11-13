using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form31ObjetoFichero : Form
    {
        List<Producto> obj = new List<Producto>();
        FileInfo file;
        public Form31ObjetoFichero()
        {
            InitializeComponent();
            file = new FileInfo("1.txt");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            TextReader reader = file.OpenText();
            for (int i = 0; i <= obj.Count - 1; i++) { 
                String contenido = reader.ReadLine();
                this.listBox1.Items.Add(contenido);
            }
           
            
            reader.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            String precio = this.txtPrecio.Text;

            Producto producto = new Producto();

            producto.Nombre = nombre;
            producto.Precio = precio;
            obj.Add(producto);

            using (TextWriter writer = file.CreateText())
            {
                foreach (Producto prod in obj)
                {
                    String datos = prod.Nombre + "-" + prod.Precio;
                    writer.WriteLine(datos);
                }
                writer.Flush();
            }
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach (Producto prod in obj)
            {
                this.listBox1.Items.Add(prod.Nombre + " " + prod.Precio);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelected = this.listBox1.SelectedIndex;
            //Con setselected podré jugar con los indices para que me seleccione
            //si sube -1 y si baja +1
            for (int i = 0; i <= this.obj.Count -1; i++) {
                int indiceProducto = i;
                Producto product = this.obj[i];
                if (indiceSelected == indiceProducto)
                {
                    this.txtNombre.Text = product.Nombre;
                    this.txtPrecio.Text = product.Precio;
                }
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indiceSelected = this.listBox1.SelectedIndex;
            if (indiceSelected != 0) 
            { 
                int nuevoIndice = indiceSelected - 1;
                this.listBox1.SetSelected(nuevoIndice, true);
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indiceSelected = this.listBox1.SelectedIndex;
            if (indiceSelected != this.listBox1.Items.Count -1) { 
                int nuevoIndice = indiceSelected + 1;
                this.listBox1.SetSelected(nuevoIndice, true);
            }
        }
    }
}
