using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [Table("LIBROS")]
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdLibro")]
        public int IdLibro { get; set; }
        [Column("Titulo")]
        public String Titulo { get; set; }
        [Column("Autor")]
        public String Autor { get; set; }
        [Column("Editorial")]
        public String Editorial { get; set; }
        [Column("Portada")]
        public String Portada { get; set; }
        [Column("Resumen")]
        public String Resumen { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("IdGenero")]
        public int IdGenero { get; set; }
    }
}