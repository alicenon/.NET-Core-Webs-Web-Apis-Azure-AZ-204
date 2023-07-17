using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _03EJEM_CONSUMIR_WEB_API_PERSONAS_WINFORM.Modelos
{
    internal class Personas
    {
        [JsonProperty("idPersona")]
        public int Numero { get; set; }
        [JsonProperty("nombre")]
        public String Nombre { get; set; }
        [JsonProperty("email")]
        public String Email { get; set; }
        [JsonProperty("edad")]
        public int Edad { get; set; }
    }
}
