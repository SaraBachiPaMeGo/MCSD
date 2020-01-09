using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProyectCache.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Es obligatorio el nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio el apellido")]
        public String Apellidos { get; set; }

        [Required(ErrorMessage = "Es obligatorio la edad")]
        [DataType(DataType.Currency)] // Para que coja números
        public int Edad { get; set; }

        [Required(ErrorMessage = "Es obligatorio el email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}