using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Models
{
    [Table("Peliculas")]
    public class Peli
    {
        [Key]
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
        [Column("IdDistribuidor")]
        public int IdDistribuidor { get; set; }

        [Column("IdGenero")]
        public int IdGenero { get; set; }

        [Column("Titulo")]
        public String Titulo { get; set; }

        [Column("IdNacionalidad")]
        public int IdNacionalidad { get; set; }

        [Column("Argumento")]
        public String Argumento { get; set; }

        [Column("Foto")]
        public String Foto { get; set; }
        [Column("Fecha_Estreno")]
        public DateTime Fecha_Estreno { get; set; }

    }
}