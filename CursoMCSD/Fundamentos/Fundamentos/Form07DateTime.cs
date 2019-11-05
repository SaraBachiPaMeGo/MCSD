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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString(); 
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            int incre = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.radioButton3.Checked == true) {
                fecha = fecha.AddYears(incre);
            } else if (this.radioButton2.Checked == true) {
                fecha = fecha.AddMonths(incre);
            }
            else {
                fecha = fecha.AddDays(incre);
            }

            this.txtResultado.Text = fecha.ToString();

            //Preguntar por el año bisiesto
            this.lblresumen.Text = "Año Bisiesto: "
                + DateTime.IsLeapYear(fecha.Year)
                + "\nDía semana: " + fecha.DayOfWeek
                + "\nDía año: " + fecha.DayOfYear;

        }

        private void chckCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chckCambiarFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }
    }
}
