using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaPeliculas.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Direccion")]
        public String Direccion { get; set; }

        [Column("Email")]
        public String Email { get; set; }
        [Column("CPostal")]
        public int CPostal { get; set; }
        [Column("PaginaWeb")]
        public String PaginaWeb { get; set; }
        [Column("Imagen_Cliente")]
        public String Imagen_Cliente { get; set; }

    }
}