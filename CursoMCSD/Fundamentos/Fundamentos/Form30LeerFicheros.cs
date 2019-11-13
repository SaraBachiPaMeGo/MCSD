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

namespace Fundamentos
{
    public partial class Form30LeerFicheros : Form
    {
        public Form30LeerFicheros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) {
                String ruta = ofd.FileName;
                FileInfo file = new FileInfo(ruta);
                //UTILIZAR, CREAR Y DESTRUIR UN OBJETO EN 1 INSTRUCCIÓN
                using (TextWriter write = file.CreateText()) { 
                    //Se crea lo que queremos utilizar
                    write.WriteLine(this.txtResult.Text);
                        //Cerramos los métodos de lectura y escritura
                        //y liberar la memoria (DISPOSED) con Flush();
                    write.Flush();
                    write.Close(); //No es necesario ponerlo
                }
                //Aquí esta cerrado y la memoria liberada 
                this.txtResult.Text = "";
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) {
                String ruta = ofd.FileName;
                FileInfo info = new FileInfo(ruta);
                TextReader reader = info.OpenText();
                String datos = await reader.ReadToEndAsync(); //Leer de forma asíncrona
                reader.Close();
                //No hay que liberar memoria
                this.txtResult.Text = datos;
            }
        }
    }
}
