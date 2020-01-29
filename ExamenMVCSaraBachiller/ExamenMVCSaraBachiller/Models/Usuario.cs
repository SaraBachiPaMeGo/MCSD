using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Apellidos")]
        public String Apellidos { get; set; }
        [Column("Email")]
        public String Email { get; set; }
        [Column("Pass")]
        public String Pass { get; set; }
        [Column("Foto")]
        public String Foto { get; set; }
    }
}