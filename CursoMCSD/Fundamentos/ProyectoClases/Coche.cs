using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Coche
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public Byte[] Imagen { get; set; }

        public String Color { get; set; }

        private int VelocidadActual = 10;

        private int VelocidadMaxima = 200;
        public int Acelerar()
        {            
            if (this.VelocidadActual <= VelocidadMaxima) { 
                return (this.VelocidadActual += 10);
            }
            return this.VelocidadActual = this.VelocidadMaxima; 
        }
        public int Frenar()
        {
            if (this.VelocidadActual >= 0) { 
                return (this.VelocidadActual -= 10);
            }
            return VelocidadActual = 0;
        }
    }
}
