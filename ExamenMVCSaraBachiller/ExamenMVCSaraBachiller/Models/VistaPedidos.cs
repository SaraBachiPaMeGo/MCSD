using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [Table("VISTAPEDIDOS")]
    public class VistaPedidos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDVISTAPEDIDOS")]
        public int IdVistaPedidos { get; set; }
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Apellidos")]
        public String Apellidos { get; set; }

        [Column("Titulo")]
        public String Titulo { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("Portada")]
        public String Portada { get; set; }

        [Column("FECHA")]
        public DateTime Fecha { get; set; }

        [Column("PRECIOFINAL")]
        public int PrecioFinal { get; set; }
    }
}