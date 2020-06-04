using System;
using System.Collections.Generic;
using System.Text;

namespace DatosPersonaje
{

    public enum Caracteristicas
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    }

    public class Personaje
    {
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaDeNacimiento;
        private int edad;
        private int salud;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }

        public int EdadDelPersonaje()
        {
            int Edad;
            Edad = DateTime.Now.Year - FechaDeNacimiento.Year;

            return Edad;
        }
    }
}
