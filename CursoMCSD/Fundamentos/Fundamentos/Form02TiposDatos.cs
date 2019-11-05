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
    public partial class Form02TiposDatos : Form
    {
        public Form02TiposDatos()
        {
            InitializeComponent();
        }

        private void Form02TiposDatos_Load(object sender, EventArgs e)
        {
            //CONVERSIÓN ENTRE TIPOS WAPPER (PRIMITIVOS)
            //SI EL TIPO A CONVERTIR ES DE MAYOR CAPACIDAD
            //LA CONVERSIÓN ES AUTOMÁTICA (ALMACENAR EN UN 
            //TIPO MENOR). 
            int num = 14;
            //UN DOUBLE PERMITE MAYOR CAPACIDAD QUE UN INT
            //Queremos almacenar un int en un double
            double dato = num;
            //La conversión es automática
            //CONVERSIÓN ENTRE TIPOS
            //SE UTILIZA CASTING 
            //Un short es menor que un int
            //short peque = num;
            //La conversión no es atomática por lo que casting
            //(TipoAconvertir) objecto
            short peque = (short)num;
            //DEL MISMO TIPO
            //CONVERSIÓN DE STRING A PRIMITIVO
            //SE REALIZA CON MÉTODOS PARSE()
            //primitivo.Parse(String);
            //Queremos almacenar un int un texto
            String texto = "1555";
            //int n = texto;
            int n = int.Parse(texto);
            //NO HACE MILAGROS PERO PUEDE GENERAR ERRORES EN 
            //EJECUCIÓN
            //Convertir cualquier objeto a String
            //LA CLASE System.Object TIENE UN MÉTODO PARA 
            // CONVERTIR CUALQUIER COSA A STRING
            // GRACIAS A toString()
            String txt = this.ToString();
            txt = num.ToString();
            txt = this.BackColor.ToString();



        }
    }
}
