using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        [Column("IdGenero")]
        public int IdGenero { get; set; }
        [Column("Genero")]
        public String Generos { get; set; }

    }
 }