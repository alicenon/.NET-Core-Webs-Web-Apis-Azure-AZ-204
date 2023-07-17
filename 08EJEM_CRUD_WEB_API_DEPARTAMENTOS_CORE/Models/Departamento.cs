using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        public int Numero { get; set; }
        [Column("dNOMBRE")]
        public string? Nombre { get; set; }
        [Column("LOC")]
        public string? Localidad { get; set; }
        
    }
}
