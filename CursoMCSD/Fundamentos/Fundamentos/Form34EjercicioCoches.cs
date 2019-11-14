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
    public partial class Form34EjercicioCoches : Form
    {
        ListaCoches listaCoches;
        XmlSerializer xmlserial;
        String ruta;
        public Form34EjercicioCoches()
        {
            InitializeComponent();
            listaCoches = new ListaCoches();
            xmlserial = new XmlSerializer(typeof(ListaCoches));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(ruta);
            //this.xmlserial.Deserialize(reader,this.listaCoches);
            this.listaCoches = (ListaCoches)this.xmlserial.Deserialize(reader);

            reader.Close();
            PintarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            DialogResult result = ofd.ShowDialog();
            if(result== DialogResult.OK) {
                ruta = ofd.FileName;
                FileInfo info = new FileInfo(ruta);
                StreamWriter writer = new StreamWriter(ruta);
                this.xmlserial.Serialize(writer,this.listaCoches); //Dos parámetros
                        
                writer.Flush();
                writer.Close();

                this.txtMarca.Text = "";
                this.txtModelo.Text = "";
                this.pictureBox1.Image = null;

                this.lstCoches.Items.Clear();
                this.listaCoches.Clear(); // Lo borro porque ya lo he guardado en el fichero
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String marca = this.txtMarca.Text;
            String modelo = this.txtModelo.Text;
            Image imagen = this.pictureBox1.Image;

            Coche coche = new Coche();

            ImageConverter imageConverter = new ImageConverter();
            byte[] xByte = (byte[])imageConverter.ConvertTo(imagen, typeof(byte[]));

            coche.Marca = marca;
            coche.Modelo = modelo;
            coche.Imagen = xByte;
            {
                //using (var ms = new MemoryStream())
                //{
                //    imageIn.Save(ms, imageIn.RawFormat);
                //    return ms.ToArray();
                //}

                //ImageConverter _imageConverter = new ImageConverter();
                //byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
                //return xByte;
            }
            this.listaCoches.Add(coche);
            PintarDatos();
        }

        private void PintarDatos() {

            foreach (Coche car in this.listaCoches) {
                this.lstCoches.Items.Add(car.Modelo + " - " + car.Marca);
            }
        }
        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstCoches.SelectedIndex;
            for (int i = 0; i <= this.listaCoches.Count - 1; i++) {
                Coche car = this.listaCoches[indice];
                this.txtMarca.Text = car.Marca;
                this.txtModelo.Text = car.Modelo;
                //string imagenConvertida = Encoding.GetEncoding(1252).GetString(car.Imagen);
                MemoryStream newStream = new MemoryStream(car.Imagen);
                Image image = Image.FromStream(newStream);

                this.pictureBox1.Image = image;
            }
        }
        
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Abrir una carpeta - SELECCIONAR UN FICHERO 
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) {
                String ruta2 = ofd.FileName;
                this.pictureBox1.Image = Image.FromFile(ruta2);
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            int indice = this.lstCoches.SelectedIndex;
            for (int i = 0; i <= this.listaCoches.Count - 1; i++)
            {
                Coche car = this.listaCoches[indice];
                this.lblVelocidad.Text = (car.Acelerar()).ToString();
            }
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            int indice = this.lstCoches.SelectedIndex;
            for (int i = 0; i <= this.listaCoches.Count - 1; i++)
            {
                Coche car = this.listaCoches[indice];
                this.lblVelocidad.Text = (car.Frenar()).ToString();
            }
        }
    }
}
