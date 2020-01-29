using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Models
{
    public class Coche : ICoche
    {
        public Coche()
        {
            this.Velocidad = 0;
            this.VelocidadMax = 140;
            this.Marca = "Volkswagen";
            this.Modelo = "Escarabajo";
            this.Imagen = "Coche1.jpg";
        }
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public String Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMax { get; set; }

        public void Acelerar()
        {
            this.Velocidad += 20;
            if (this.Velocidad >= VelocidadMax)
            {
                this.Velocidad = VelocidadMax;
            }
        }
        public void Frenar()
        {
            this.Velocidad -= 20;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
        }

    }
}
