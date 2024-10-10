using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public abstract class Vehiculo : IVehiculo
    {
        protected int velocidad;

        public Vehiculo()
        {
            velocidad = 0;
        }

        public abstract void Acelerar();
        public abstract void Frenar();

        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}