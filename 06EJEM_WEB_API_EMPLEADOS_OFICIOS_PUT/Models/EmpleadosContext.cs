using Microsoft.EntityFrameworkCore;

namespace _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Models
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Empleado> EMP { get; set; }
    }
}
