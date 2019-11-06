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
    public partial class Form12Abstraccion : Form
    {
        public Form12Abstraccion()
        {
            InitializeComponent();

            //FOREACH (char letra in texto)
            //Queremos hacer algo con todos los controles
            foreach (Control c in this.Controls) {
                c.BackColor = Color.Violet; //Todo depende del tipo de obj que haya 
                //En el interior de la collection
            }
           

        }

    }
}
