using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MenuViewComponents.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        public int Dept_no { get; set; }
        [Column("DNOMBRE")]
        public String DNombre { get; set; }

        [Column("LOC")]
        public String Loc { get; set; }
    }
}
