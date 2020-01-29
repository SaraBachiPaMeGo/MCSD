using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDPEDIDO")]
        public int IdPedido { get; set; }
        [Column("IDFACTURA")]
        public int IdFactura { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("IDLIBRO")]
        public int IdLibro { get; set; }
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }
        [Column("CANTIDAD")]
        public int Cantidad { get; set; }
    }
}