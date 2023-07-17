using _05EJEM_API_EMPLEADOS_CORE.Data;
using _05EJEM_API_EMPLEADOS_CORE.Models;

namespace _05EJEM_API_EMPLEADOS_CORE.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }

        public Empleado? BuscarEmpleado(int idempleado){

            return context.Empleados.FirstOrDefault(x => x.IdEmpleado == idempleado);
        }
    }
}
