using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEntityFramework.Models
{
    public class GrupoPlantilla
    {
        public int NumeroRegistros { get; set;}
        public List<PAGINARGRUPO_Result> Plantilla { get; set; }
    }
}