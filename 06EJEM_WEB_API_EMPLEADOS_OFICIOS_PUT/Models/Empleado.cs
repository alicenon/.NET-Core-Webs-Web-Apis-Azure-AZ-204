using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Models
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

        [Column("DIR")]
        public int dir { get; set; }

        [Column("Fecha_alt")]
        public DateTime FECHA { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }

        [Column("COMISION")]
        public int Comision { get; set; }

        [Column("DEPT_NO")]
        public int Departamento { get; set; }
    }
}
