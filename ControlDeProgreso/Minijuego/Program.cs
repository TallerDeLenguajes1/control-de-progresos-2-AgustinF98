using System;
using DatosPersonaje;

namespace Minijuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valoresAleatorios = new Random();
            valoresAleatorios.Next((int)Caracteristicas.velocidad);
            valoresAleatorios.Next((int)Caracteristicas.destreza);
            valoresAleatorios.Next((int)Caracteristicas.fuerza);
            valoresAleatorios.Next((int)Caracteristicas.nivel);
            valoresAleatorios.Next((int)Caracteristicas.armadura);
        }
    }
}
