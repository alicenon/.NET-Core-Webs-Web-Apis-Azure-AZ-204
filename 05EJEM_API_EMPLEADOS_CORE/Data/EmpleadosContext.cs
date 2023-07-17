using _05EJEM_API_EMPLEADOS_CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace _05EJEM_API_EMPLEADOS_CORE.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
