﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public interface IVehiculo
    {
        void Acelerar();
        void Frenar();
        int ObtenerVelocidad();
    }
}