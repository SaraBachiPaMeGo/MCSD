using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguridadEmpleados.Models
{
    [Table ("EMP")]
    public class Empleados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMP_NO")]
        public int Emp_no { get; set;}
        [Column("APELLIDO")]
        public String Nombre { get; set; }
        [Column("OFICIO")]
        public String Oficio { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}