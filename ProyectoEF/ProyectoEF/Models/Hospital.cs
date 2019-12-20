using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoEF.Models
{
    [Table("HOSPITAL")] //Para hacer esto debemos descargarnos el nuget: entityFramework
    public class Hospital
    {
        //Hay que definir una PK,aunque ya tenga en la tabla
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Sirve para
        [Column("HOSPITAL_COD")]
        public int CodHospi { get; set; }
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