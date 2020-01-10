using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguridadDoctores.Models
{
    [Table("DOCTOR")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DOCTOR_NO")]
        public int Doctor_no { get; set; }
        [Column("HOSPITAL_COD")]
        public int Hospital_cod { get; set; }
        [Column("APELLIDO")]
        public String Apellido{ get; set; }
        [Column("ESPECIALIDAD")]
        public String Especialidad { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}