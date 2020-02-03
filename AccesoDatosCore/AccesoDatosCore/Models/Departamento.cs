using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatosCore.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        //[Required(ErrorMessage = "CAMPO OBLIGATORIO ")]
        public int Dept_no { get; set; }
        [Column("DNOMBRE")]
        //[Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public String DNombre { get; set; }

        //[Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [Column("LOC")]
        public String Loc { get; set; }
    }
}
