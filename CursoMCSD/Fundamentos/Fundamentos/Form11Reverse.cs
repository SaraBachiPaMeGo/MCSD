using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11Reverse : Form
    {
        public Form11Reverse()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Stopwatch crono = new Stopwatch();
            crono.Start();
            String frase = this.txtInput.Text;
            //REMOVE E INSERT
            // hola
            // ahol
            // alho
            // aloh
            for (int i =0; i<frase.Length; i++ )
            {
                //Recuperamos la última letra 
                char letra = frase[frase.Length - 1];
                //Eliminamos la última letra
                frase = frase.Remove(frase.Length -1);
                //Insertamos la letra en la posición de i
                frase = frase.Insert(i, letra.ToString());
            }
            this.txtResult.Text = frase;
            crono.Stop();
            //Adaptación
            TimeSpan time = crono.Elapsed;
            this.txtResult.Text = "Segundos: " + time.TotalSeconds
                + "\nMilisegundos: " + time.TotalMilliseconds;
        }

        private void btnInvertir2_Click(object sender, EventArgs e)
        {
            Stopwatch crono = new Stopwatch();
            crono.Start();
           
            //CREAMOS EL OBJ 1 VEZ
            StringBuilder frase = new StringBuilder();
            //LO MANEJAMOS
            frase.Append(this.txtInput.Text);
            for (int i =0; i<frase.Length; i++) { 
                char letra = frase[frase.Length - 1];
                //Eliminamos la última letra
                frase = frase.Remove(frase.Length - 1,1);
                frase = frase.Insert(i, letra);
                //Estamos asociando la misma memoria para el objeto
            }
            crono.Stop();
            this.txtResult.Text = frase.ToString();
            //Adaptación
            TimeSpan time = crono.Elapsed;
            this.txtResult.Text = "Segundos: " + time.TotalSeconds
                + "\nMilisegundos: " + time.TotalMilliseconds;
        }
    }
}
