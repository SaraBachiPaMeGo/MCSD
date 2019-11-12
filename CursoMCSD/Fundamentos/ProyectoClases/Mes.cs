using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    
    public class Mes
    {

        public int CalcularMedia(int max, int min) {
            return (max + min) / 2;
        }
        public String Nombre { get;set; }
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public int Media { get; set; }
    }
}
