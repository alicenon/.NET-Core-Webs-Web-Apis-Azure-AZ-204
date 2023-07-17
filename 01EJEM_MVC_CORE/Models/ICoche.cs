namespace _01EJEM_MVC_CORE.Models
{
    public interface ICoche
    {

        String Marca { get; set; }
        String Modelo { get; set; }

        String Imagen { get; set; }

        int VelocidadMaxima { get; set; }

        int VelocidadActual { get; set; }

        int Acelerar();

        int Frenar();
    }
}
