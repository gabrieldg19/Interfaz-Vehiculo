using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Motocicleta : IVehiculo
    {
        private int velocidad;

        public Motocicleta()
        {
            velocidad = 0;
        }

        public void Acelerar()
        {
            velocidad += 15;
            Console.WriteLine("La motocicleta acelera. Velocidad actual: " + velocidad + " km/h");
        }

        public void Frenar()
        {
            velocidad -= 7;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("La motocicleta frena. Velocidad actual: " + velocidad + " km/h");
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}