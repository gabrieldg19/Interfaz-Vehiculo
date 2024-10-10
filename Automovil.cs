using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Automovil : IVehiculo
    {
        private int velocidad;

        public Automovil()
        {
            velocidad = 0;
        }

        public void Acelerar()
        {
            velocidad += 10;
            Console.WriteLine("El automóvil acelera. Velocidad actual: " + velocidad + " km/h");
        }

        public void Frenar()
        {
            velocidad -= 5;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("El automóvil frena. Velocidad actual: " + velocidad + " km/h");
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}