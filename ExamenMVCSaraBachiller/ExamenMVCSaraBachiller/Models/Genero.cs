using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [Table("GENEROS")]
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdGenero")]
        public int IdGenero { get; set; }
        [Column("Nombre")]
        public String NombreGenero { get; set; }
    }
}