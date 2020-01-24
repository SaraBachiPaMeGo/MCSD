using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoErrores.Models
{
        [Table("EXCEPCIONES")]
        public class Excepcion
        {
            [Key]
            [Column("IDEXCEPCION")]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int ExceptionID { get; set; }
            [Column("MENSAJE")]
            public string Message { get; set; }
            [Column("CONTROLADOR")]
            public string Controller { get; set; }

            [Column("FECHA")]
            public DateTime Date { get; set; }
        }
}