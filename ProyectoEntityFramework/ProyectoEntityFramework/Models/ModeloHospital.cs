using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEntityFramework.Models
{
    public class ModeloHospital
    {
        public int NumeroRegistros { get; set; }
        public  PAGINARHOSPITALES_Result Hospital { get; set; }

        public List<DOCTOR> ListaDoctores { get; set; }
    }
}