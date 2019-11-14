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
    public partial class Form32SerializacionProducto : Form
    {
        XmlSerializer xmlserial;
        public Form32SerializacionProducto()
        {
            InitializeComponent();
            //En el momento de instanciarlo debemos indicar la 
            //clase que va a serializar o deserializar (Con qué clase
            // va a trabajar)
            //Producto p = new Producto();
            //p.GetTyppe();
            this.xmlserial = new XmlSerializer(typeof(Producto)); // Dentro hay que
            //Especificar el tipo de objeto a trabajar
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("producto.xml");
            //Con el método deserialize() l eneviamos el reader y nos
            //devuelve el obj
            Producto product = (Producto)this.xmlserial.Deserialize(reader);
            reader.Close();
            this.txtNombre.Text = product.Nombre;
            this.txtPrecio.Text = product.Precio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Nombre = this.txtNombre.Text;
            product.Precio = this.txtPrecio.Text;
            //Para serializar  utilizamos el obj --> StreamWriter
            StreamWriter writer = new StreamWriter("producto.xml"); //ruta
            //Con el método serialize del obj xml le enviamos el writer
            //y el obj a serializar
            this.xmlserial.Serialize(writer, product);
            writer.Flush();
            writer.Close();
            
            this.txtNombre.Text = "";
            this.txtPrecio.Text = ""; 
        }
    }
}
