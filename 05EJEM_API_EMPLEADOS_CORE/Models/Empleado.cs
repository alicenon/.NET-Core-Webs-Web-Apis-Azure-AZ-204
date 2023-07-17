using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _05EJEM_API_EMPLEADOS_CORE.Models

{
    [Table("EMP")]
    public class Empleado
    {

        [Key]
        [Column("EMP_NO")]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        public String? Apellido { get; set; }
        [Column("OFICIO")]
        public String? Oficio { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("DEPT_NO")]
        public int Departamento { get; set; }
    }
}
