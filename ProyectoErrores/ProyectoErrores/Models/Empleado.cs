using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoErrores.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMP_NO")]
        public int Emp_no { get; set; }
        [Column("APELLIDO")]
        public String Nombre { get; set; }
        [Column("OFICIO")]
        public String Oficio { get; set; }

        [Column("FECHA_ALT")]
        public DateTime FECHA_ALT { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }

        [Column("DIR")]
        public int Dir { get; set; }
        [Column("DEPT_NO")]
        public int Dept_no { get; set; }
    }
}