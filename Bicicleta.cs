using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Bicicleta : IVehiculo
    {
        private int velocidad;

        public Bicicleta()
        {
            velocidad = 0;
        }

        public void Acelerar()
        {
            velocidad += 3;
            Console.WriteLine("La bicicleta acelera. Velocidad actual: " + velocidad + " km/h");
        }

        public void Frenar()
        {
            velocidad -= 2;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("La bicicleta frena. Velocidad actual: " + velocidad + " km/h");
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}