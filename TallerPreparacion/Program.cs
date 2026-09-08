using System;

namespace TallerPreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int contador = 0;
            bool seguir = true;

            do
            {
                Console.Write("Introduce una calificación (0-100): ");
                string entrada = Console.ReadLine();

                int calificacion;
                
                while (!int.TryParse(entrada, out calificacion) || calificacion < 0 || calificacion > 100)
                {
                    Console.Write("Entrada inválida. Introduce un entero entre 0 y 100: ");
                    entrada = Console.ReadLine();
                }

                suma = suma + calificacion;
                contador = contador + 1;

                Console.Write("¿Desea capturar otra calificación? (S/N): ");
                string respuesta = Console.ReadLine();
                if (respuesta.Length > 0 && (respuesta[0] == 'S' || respuesta[0] == 's'))
                {
                    seguir = true;
                }
                else
                {
                    seguir = false;
                }

            } while (seguir);

            if (contador == 0)
            {
                Console.WriteLine("No se capturaron calificaciones.");
            }
            else
            {
                
                float promedio = suma / (float)contador;
                Console.WriteLine("Se capturaron " + contador + " calificación(es). Promedio: " + promedio);
            }

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadKey();
        }
    }
}
