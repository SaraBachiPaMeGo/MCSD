using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcProyectCache.Models
{
    [Table("EMP")]
    public class Empleado 
    {
        [Key]
        [Column("EMP_NO")]
        public int NumEmp { get; set; }
        [Column("APELLIDO")]
        public String Nombre { get; set; }
        [Column("OFICIO")]
        public String Oficio { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("DEPT_NO")]
        public int NumDept { get; set; }
    }
}