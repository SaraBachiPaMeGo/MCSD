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
    public partial class Form06DiaSemana : Form
    {
        public Form06DiaSemana()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int dia, mes, año;

            dia = int.Parse(this.txtDia.Text);
            mes = int.Parse(this.txtMes.Text);
            año = int.Parse(this.txtAño.Text);

            String msg="";

            switch (mes) {            
            case 1:
                    mes = 13;
                    año -= 1;
                    break;
            case 2:
                    mes = 14;
                    año -= 1;
                    break;
            }

            //Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int op1 = ((mes + 1) * 3) / 5;
            //Dividir el año entre 4
            int op2 = año / 4;
            //Dividir el año entre 100
            int op3 = año / 100;
            //Dividir el año entre 400
            int op4 = año / 400;
            // Sumar el dia, el doble del mes, el año, el resultado 
            //de la operación 1, el resultado de la operación 2, 
            //menos el resultado de la operación 3 más la operación 4 más 2.
            int op5 = dia + (2 * mes) + año + op1 + op2 - op3 + op4 + 2;
            //Dividir el resultado anterior entre 7.
            int op6 = op5 / 7;
            //Restar el número del paso 5 con el número del paso 6 por 7.
            int op7 = op5 - (op6 * 7);

            switch (op7)
            {
                case 0:
                    msg = "SÁBADO";
                    break;
                case 1:
                    msg = "DOMIGO";
                    break;
                case 2:
                    msg = "LUNES";
                    break;
                case 3:
                    msg = "MARTES";
                    break;
                case 4:
                    msg = "MIÉRCOLES";
                    break;
                case 5:
                    msg = "JUEVES";
                    break;
                case 6:
                    msg = "VIERNES";
                    break;
            }
            this.txtResul.Text = msg;
        }
    }
}
