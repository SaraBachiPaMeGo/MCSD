using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicioApiCoches.Models
{
    [Table("COCHES")]
    public class Coche
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCOCHE")]
        public int IdCoche { get; set; }
        [Column("MARCA")]
        public String Marca { get; set; }
        [Column("MODELO")]
        public String Modelo { get; set; }
        [Column("CONDUCTOR")]
        public String Conductor { get; set; }
        [Column("IMAGEN")]
        public String Imagen { get; set; }
    }
}