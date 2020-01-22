using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Models
{
    [Table("USERSHASH")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("USUARIO")]
        public string User { get; set; }
        [Column("PASS")]
        public byte[] Pass { get; set; }
        [Column("SALT")]
        public string Salt { get; set; }
    }
}