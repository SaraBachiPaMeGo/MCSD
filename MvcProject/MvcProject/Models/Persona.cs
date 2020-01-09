using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Persona
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public String Nombre { get; set; }
        [Required(ErrorMessage ="Apellidos obligatorio")]
        public String Apellidos { get; set; }
        [Required(ErrorMessage ="La Edad es obligatoria")]
        [DataType(DataType.Currency)]
        public int Edad { get; set; }
        [Required(ErrorMessage ="Email obligatorio")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}