namespace _01EJEM_MVC_CORE.Models
{
    public class Deportivo : ICoche
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public String Imagen { get; set; }

        public int VelocidadMaxima { get; set; }

        public int VelocidadActual { get; set; }

        public Deportivo()
        {
            this.Marca = "Pontiac";
            this.Modelo = "FireBird";
            this.Imagen = "kitt.jpg";
            this.VelocidadActual = 0;
            this.VelocidadMaxima = 180;
        }

        public Deportivo(String marca, String modelo, String imagen, int velocidadmaxima)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Imagen = imagen;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = velocidadmaxima;
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
            this.VelocidadActual = 0;
            //this.VelocidadActual -= 20;
            if (this.VelocidadActual < 0)
            {
                this.VelocidadActual = 0;
            }
            return this.VelocidadActual;
        }
    }
}
