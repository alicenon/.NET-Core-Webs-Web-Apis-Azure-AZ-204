using _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Data;
using _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Models;

namespace _08EJEM_CRUD_WEB_API_DEPARTAMENTOS_CORE.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;
        public RepositoryDepartamentos(DepartamentosContext context) {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento BuscarDepartamento(int? deptno) {

            Departamento dep= context.Departamentos.SingleOrDefault(x => x.Numero == deptno.Value);
            return dep;
        }
        public void InsertarDepartamento(int num, string nom, string loc)
        {
            Departamento dept = new Departamento();
            dept.Numero = num;
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();

        }
        public void ModificarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = this.BuscarDepartamento(num);
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.SaveChanges();
        }
        public void EliminarDepartamento(int num)
        {
            Departamento dept = this.BuscarDepartamento(num);
            this.context.Departamentos.Remove(dept);
            this.context.SaveChanges();
        }


    }
}
