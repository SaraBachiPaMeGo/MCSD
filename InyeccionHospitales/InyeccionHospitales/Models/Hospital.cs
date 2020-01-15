

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InyeccionHospitales.Models
{
    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [Column("HOSPITAL_COD")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHospital { get; set; }

        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("DIRECCION")]
        public String Direccion { get; set; }
        [Column("TELEFONO")]
        public String Telefono { get; set; }
        [Column("NUM_CAMA")]
        public int Camas { get; set; }
    }
}