using _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext(DbContextOptions options):base (options) { }

        public DbSet<Departamento> Departamentos { get; set; }

    }
}
