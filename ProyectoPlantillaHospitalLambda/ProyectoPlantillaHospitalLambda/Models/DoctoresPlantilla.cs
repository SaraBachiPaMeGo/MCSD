using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlantillaHospitalLambda.Models
{
    public class DoctoresPlantilla
    {
        public String apellido { get; set; }
        public String trabajo { get; set; }
        public int salario { get; set; }
        public int SumaSalarial { get; set; }
        public double MediaSalarial { get; set; }
        public int Hospital_cod { get; set; }

    }
}