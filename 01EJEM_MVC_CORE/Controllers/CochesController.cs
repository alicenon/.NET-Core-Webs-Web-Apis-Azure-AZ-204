using _01EJEM_MVC_CORE.Models;//
using Microsoft.AspNetCore.Mvc;

namespace _01EJEM_MVC_CORE.Controllers
{
    public class CochesController : Controller
    {
        //private Coche car;
        private ICoche car;

        //public CochesController(Coche car)
        public CochesController(ICoche car)
        {
            this.car = car;
            //this.car = new Coche();
        }

        public IActionResult Index()
        {
            return View(this.car);
        }

        [HttpPost]
        public IActionResult Index(String accion)
        {
            if (accion == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}
