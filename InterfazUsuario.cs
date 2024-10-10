using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class InterfazUsuario
    {
        public static void MenuInteraccion()
        {
            List<IVehiculo> vehiculos = new List<IVehiculo>
        {
            new Automovil(),
            new Bicicleta(),
            new Motocicleta()
        };

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione un vehículo para interactuar:");
                Console.WriteLine("1. Automóvil");
                Console.WriteLine("2. Bicicleta");
                Console.WriteLine("3. Motocicleta");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                {
                    salir = true;
                    Console.WriteLine("Saliendo del programa.");
                    continue;
                }

                IVehiculo vehiculoSeleccionado = vehiculos[opcion - 1];

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Acelerar");
                Console.WriteLine("2. Frenar");
                Console.WriteLine("3. Mostrar velocidad");
                int accion = int.Parse(Console.ReadLine());

                switch (accion)
                {
                    case 1:
                        vehiculoSeleccionado.Acelerar();
                        break;
                    case 2:
                        vehiculoSeleccionado.Frenar();
                        break;
                    case 3:
                        Console.WriteLine("Velocidad actual: " + vehiculoSeleccionado.ObtenerVelocidad() + " km/h");
                        break;
                }

                Console.WriteLine("\n");
            }
        }
    }
}