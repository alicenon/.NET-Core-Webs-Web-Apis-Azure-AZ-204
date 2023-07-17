using _05EJEM_API_EMPLEADOS_CORE.Models;
using _05EJEM_API_EMPLEADOS_CORE.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _05EJEM_API_EMPLEADOS_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Empleado>> Get()
        {
            return this.repo.GetEmpleados();
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado?> Get(int id)
        {
            return this.repo.BuscarEmpleado(id);
        }
    }
}
