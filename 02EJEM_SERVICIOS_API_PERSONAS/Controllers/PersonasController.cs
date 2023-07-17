using _02EJEM_SERVICIOS_API_PERSONAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02EJEM_SERVICIOS_API_PERSONAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        List<Persona> listapersonas = new List<Persona>();

        public PersonasController()
        {
            Persona p = new Persona { IdPersona = 1, Nombre = "Emanuel Alejandro", Email = "limasotoalejandro@gmail.com", Edad = 19 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 2, Nombre = "Adrian", Email = "adrian@gmail.com", Edad = 24 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 3, Nombre = "Alejandro", Email = "alejandro@gmail.com", Edad = 21 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 4, Nombre = "Shannon", Email = "shannon@gmail.com", Edad = 26 };
            this.listapersonas.Add(p);
        }
        // GET: api/<PersonasController>
        [HttpGet]
        public List<Persona> GetPersonas()
        {
            return this.listapersonas;
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public Persona GetPersona(int id)
        {
            Persona p = this.listapersonas.Find(z => z.IdPersona == id);
            return p;
        }

    }
}
