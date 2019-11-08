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
    public partial class Form18MetodosEvento : Form
    {
        public Form18MetodosEvento()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_MouseMove(object sender, MouseEventArgs e)
        {
            this.txtResult.Text = "X: " + e.X + "\nY: " + e.Y;
        }

        private void txtResult_MouseHover(object sender, EventArgs e)
        {
            //Dentro de los argumentos me viene la información del tipo de evento
            
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Preguntar por la tecla borrar y su código ASCII con: Keys.tecla
            //Keys.Back; INT
            
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char) Keys.Back)
            {
            e.Handled = true; //false ACTIVA LOS EVENTOS SUCESIVOS
            //con true deja de hacer los eventos despues no escribe nada 
            }
            
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //false ACTIVA LOS EVENTOS SUCESIVOS
                                  //con true deja de hacer los eventos despues no escribe nada 
            }
        }
    }
}
