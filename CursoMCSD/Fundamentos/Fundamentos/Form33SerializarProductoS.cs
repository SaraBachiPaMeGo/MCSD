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
using System.Xml.Serialization;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form33SerializarProductoS : Form
    {
        listProductos productos;
        XmlSerializer xmlserial;

        public Form33SerializarProductoS()
        {
            InitializeComponent();
            this.productos = new listProductos();
            this.xmlserial = new XmlSerializer(typeof(listProductos));
            //La clase Image permite almacenar imágenes
            //Sus métodos son estáticos
            this.pictureBox1.Image = Image.FromFile("playa.jpg");//Nombre de la imagen
        }

        private void PintarProductos() {
            this.listBox1.Items.Clear();
            foreach (Producto prod in this.productos) {
                this.listBox1.Items.Add(prod.Nombre);            
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaProductos.xml");            
            this.productos = (listProductos) this.xmlserial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaProductos.xml");
            this.xmlserial.Serialize(writer, this.productos);
            writer.Flush();
            writer.Close();
            this.listBox1.Items.Clear();
            this.productos.Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtNombre.Text;
            producto.Precio = this.txtPrecio.Text;
            this.productos.Add(producto);

            this.PintarProductos();
        }
    }
}
