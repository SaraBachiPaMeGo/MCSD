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
    public partial class Form21AsociarEventos : Form
    {
        public Form21AsociarEventos()
        {
            InitializeComponent();
            foreach (TextBox txt in this.groupLetras.Controls) {
                txt.KeyPress += SoloLetras;
            }
            foreach (TextBox num in this.groupNum.Controls)
            {
                num.KeyPress += SoloNumeros;
            }
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //false ACTIVA LOS EVENTOS SUCESIVOS
                                  //con true deja de hacer los eventos despues no escribe nada 
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            //Preguntar por la tecla borrar y su código ASCII con: Keys.tecla
            //Keys.Back; INT

            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //false ACTIVA LOS EVENTOS SUCESIVOS
                                  //con true deja de hacer los eventos despues no escribe nada 
            }

        }
    }
}
