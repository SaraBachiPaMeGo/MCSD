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
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //MÉTODO DE EVENTO (CUANDO)
            //this ES LA CLASE DONDE ESTAMOS ESCRIBIENDO (Form1)
            this.txtNombre.Text = "Soy un texto";
            //Propiedades que podemos representar
            this.txtNombre.Width = 100;
            //Clases para crear
            this.btnAccion.Size = new Size(150,200);
            //Clases finales
            //Nos ofrece las posibilidades para seleccionar
            //elementos o métodos
            this.btnAccion.BackColor= Color.Violet;
            //Enumeraciones
            // Nos ofrecen una serie de opciones limitadas
            //AMARILLO ENUMERACIÓN
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.btnAccion.Location = new Point(10,20);
        }

    }
}
