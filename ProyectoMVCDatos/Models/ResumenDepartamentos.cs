using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCDatos.Models
{
    public class ResumenDepartamentos
    {
        public int Personas { get; set; }
        public double MediaSalarial { get; set; }

        public int MaximoSalario { get; set; }

        public List<EMP> Empleados { get; set; }
        //public ResumenDepartamentos() { 
        
        //}
    }
}