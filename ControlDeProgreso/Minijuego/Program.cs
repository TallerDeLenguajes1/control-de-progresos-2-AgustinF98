using System;
using DatosPersonaje;

namespace Minijuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje Personaje = new Personaje();

            Random valoresAleatorios = new Random();
            valoresAleatorios.Next((int)Caracteristicas.velocidad);
            valoresAleatorios.Next((int)Caracteristicas.destreza);
            valoresAleatorios.Next((int)Caracteristicas.fuerza);
            valoresAleatorios.Next((int)Caracteristicas.nivel);
            valoresAleatorios.Next((int)Caracteristicas.armadura);

        }

        public Personaje AgregarDatos(Personaje Personaje, Random valoresAleatorios)
        {
            Console.Write("Ingrese el tipo de personaje: ");
            Personaje.Tipo = Console.ReadLine();
            Console.Write("\nIngrese el nombre de su personaje: ");
            Personaje.Nombre = Console.ReadLine();
            Console.Write("\nIngrese el apodo que se verá en el avatar dentro del juego: ");
            Personaje.Apodo = Console.ReadLine();
            //Fecha de nacimiento
            Personaje.FechaDeNacimiento = Convert.ToDateTime(valoresAleatorios.Next(0, 301));
            // Edad del personaje
            Personaje.EdadDelPersonaje();
            // Saludo del personaje
            Personaje.Salud = 100;

            return Personaje;
        }
    }
}
