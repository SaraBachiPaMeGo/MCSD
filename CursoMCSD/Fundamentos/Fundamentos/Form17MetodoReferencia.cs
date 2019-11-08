using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form17MetodoReferencia : Form
    {
        public Form17MetodoReferencia()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.textBox1.Text);
            //DobleValor(num);            
            CambiarColor(this.button2);
            //DobreReferencia(ref numero); // Enviamos un objeto y lo utilizamos en el método
            //Hace refencia al mismo espacio de memoria que num
            numero = RealizarDoble(numero);
            this.txtResult.Text = numero.ToString();
        }

        int RealizarDoble(int num) { 
            return num = num * 2;
        }

        //MÉTODO PARA HACER UN WRAPPER POR REFERENCIA
        void DobreReferencia(ref int num) {
            num = num * 2;
        }

        //MÉTODO POR VALOR CON WRAPPER
        void DobleValor(int num)
        {
            num = num * 2;
        }

        //Método con clase por referencia (valor por defecto)
        void CambiarColor(Control control) {
            control.BackColor = Color.Pink;
        }
    }
}
