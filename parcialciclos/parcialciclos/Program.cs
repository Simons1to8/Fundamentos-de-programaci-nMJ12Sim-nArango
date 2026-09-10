using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace parcialciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string ocupacion, genero;
            int totalTrabajan = 0;
            int totalEstudian = 0;
            int mujeresTrabajan = 0; 
            int hombresTrabajan = 0;
            int hombresEstudian = 0;
            int mujeresEstudian = 0;
            





            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Ingrese la ocupación del estudiante {i} (T para trabaja, E para estudia): ");
                ocupacion = Console.ReadLine();
                Console.WriteLine($"Ingrese el género del estudiante {i} (H para hombre, M para mujer): ");
                genero = Console.ReadLine();
                if (ocupacion == "T")
                {
                    totalTrabajan++;
                    if (genero == "M")
                    {
                        mujeresTrabajan++;
                    }
                    else if (genero == "H")
                    {
                        hombresTrabajan++;
                    }
                }
                else if (ocupacion == "E")
                {
                    totalEstudian++;
                    if (genero == "M")
                    {
                        mujeresEstudian++;
                    }
                    else if (genero == "H")
                    {
                        hombresEstudian++;
                    }
                }
                else
                {
                    Console.WriteLine("Ocupación o género inválido. Por favor ingrese T o E para ocupación, y H o M para género.");
                }
            }
            double porcentajeTrabajan = (double)totalTrabajan / 15 * 100;
            double porcentajeEstudian = (double)totalEstudian / 15 * 100;

            Console.WriteLine("\nRESULTADOS");
            Console.WriteLine($"Porcentaje que trabajan: {porcentajeTrabajan:F2}%");
            Console.WriteLine($"Porcentaje que estudian: {porcentajeEstudian:F2}%");
            Console.WriteLine($"Cantidad de mujeres que trabajan: {mujeresTrabajan}");
            Console.WriteLine($"Cantidad de hombres que estudian: {hombresEstudian}");
        }
    }
}
