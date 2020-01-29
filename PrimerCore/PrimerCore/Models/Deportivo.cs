using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Models
{
    public class Deportivo : ICoche
    {
        public Deportivo()
        {
            this.Velocidad = 0;
            this.VelocidadMax = 250;
            this.Marca = "Volkswagen";
            this.Modelo = "Escarabajo";
            this.Imagen = "Coche2.jpg";
        }
        public string Marca { get ; set ; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMax { get; set; }

        public void Acelerar()
        {
            this.Velocidad += 50;
            if (this.Velocidad >= VelocidadMax)
            {
                this.Velocidad = VelocidadMax;
            }
        }

        public void Frenar()
        {
            this.Velocidad -= 30;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
        }
    }
}
