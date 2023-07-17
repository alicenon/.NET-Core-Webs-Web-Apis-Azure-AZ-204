using _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Models;

namespace _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext contexto;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.contexto = context;
        }

        public List<String> GetOficios()
        {
            var consulta = (from datos in contexto.EMP
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in contexto.EMP
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }

        public void IncrementarSalarioOficio(int incremento, String oficio)
        {
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);
            foreach (Empleado emp in empleados)
            {
                emp.Salario += incremento;
            }
            this.contexto.SaveChanges();
        }
    }
}
