﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMPLEADO_NO")]
        public int IdPlantilla { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("FUNCION")]
        public String Funcion { get; set; }
        [Column("T")]
        public String Turno { get; set; }
        [Column("HOSPITAL_COD")]
        public int IdHospital { get; set; }
    }
}