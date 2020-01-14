using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
        [Column("Cantidad")]
        public int Cantidad { get; set; }
        [Column("Fecha")]
        public DateTime Fecha { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
    }
}