using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Ciclo Do While 
                        int contador = 1;
                        int acumulador = 0;

                        do
                        {
                            acumulador += contador;
                            contador++;

                        } while (contador > 0);
                        Console.WriteLine($"La suma de los cinco primeros números es " +
                       $"{acumulador}");
            */
/*            int contador = 1;
            int numero = 0;
            char continuar = ' ';
            do
            {
                Console.WriteLine("ingrese un numero");

                numero = int.Parse(Console.ReadLine());
                do
                {

                    Console.WriteLine($"{numero}X{contador}={numero * contador}");
                    contador++;
                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("desea continuar : s/si - otro coso para salir ");
                continuar = char.Parse(Console.ReadLine());
                
            } while (continuar == 's');
*/


        }


    }
    
}