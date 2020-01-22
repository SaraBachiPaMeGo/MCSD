using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Models
{
    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("HOSPITAL_COD")]
        public int HospiCod { get; set; }

        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("DIRECCION")]
        public String Direccion { get; set; }
        [Column("TELEFONO")]
        public String Tlf { get; set; }
        [Column("NUM_CAMA")]
        public int NumCamas { get; set; }
    }
}