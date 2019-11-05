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
    public partial class Form09ValidarEmail : Form
    {
        public Form09ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String email = this.txtEmail.Text;
            //SubString(Inicio, Numero de Caracteres): 
            //Devuelve una parte de la cadena indicando el inicio
            //y la longitud de caracteres que queremos recuperar.
            //String dom;
            //dom = email.Substring(email.LastIndexOf("."), email.Length);
            int dom = email.Length - email.LastIndexOf(".");

            if (!email.Contains("@"))
            {
                this.txtResult.Text = "No contiene ninguna @";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                this.txtResult.Text = "Contiene alguna @ al principio o al final";
            }
            else if (!email.Contains("."))
            {
                this.txtResult.Text = "No contiene ningún .";
            }
            else if (email.IndexOf(".@") != -1)
            {
                this.txtResult.Text = "Contiene .@";
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.txtResult.Text = "Hay más de una @";
            }
            else if (dom < 3 || dom > 5)
            {
                this.txtResult.Text = "Dominio no válido";
            }
            else {
                this.txtResult.Text = "Email válido";
            }

        }
    }
}
