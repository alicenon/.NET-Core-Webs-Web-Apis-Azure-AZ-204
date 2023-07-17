namespace _01EJEM_MVC_CORE.Models
{
    public class Coche :ICoche
    {

        public String Marca { get; set; }
        public String Modelo { get; set; }

        public String Imagen { get; set; }

        //public int VelocidadMaxima;
        public int VelocidadMaxima { get; set; }

        public int VelocidadActual { get; set; }

        public Coche()
        {
            this.Marca = "Volkswagen";
            this.Modelo = "Herbie Escarabajo";
            this.Imagen = "herbie.jpg";
            this.VelocidadActual = 0;
            this.VelocidadMaxima = 90;
        }

        public int Acelerar()
        {
            this.VelocidadActual += 20;
            if (this.VelocidadActual > this.VelocidadMaxima)
            {
                this.VelocidadActual = this.VelocidadMaxima;
            }
            return this.VelocidadActual;
        }

        public int Frenar()
        {
            this.VelocidadActual -= 20;
            if (this.VelocidadActual < 0)
            {
                this.VelocidadActual = 0;
            }
            return this.VelocidadActual;
        }
    }
}
