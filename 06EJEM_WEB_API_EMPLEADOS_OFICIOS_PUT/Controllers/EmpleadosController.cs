using _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Models;
using _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06EJEM_WEB_API_EMPLEADOS_OFICIOS_PUT.Controllers
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

        [HttpGet("[action]")]
        public List<String> RecuperarOficios()
        {
            return repo.GetOficios();
        }

        [HttpGet("[action]/{oficio}")]
        public List<Empleado> EmpleadosOficio(string oficio)
        {
            return repo.GetEmpleadosOficio(oficio);
        }

        [HttpPut("[action]/{incremento}/{oficio}")]
        public void IncrementarSalarios(int incremento, String oficio)
        {
            this.repo.IncrementarSalarioOficio(incremento, oficio);
        }
    }
}
