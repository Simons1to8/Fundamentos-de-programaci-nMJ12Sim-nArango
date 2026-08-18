using System;


namespace TallerCONDICIONALES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero 1 ,numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes,si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Ingresa 3 valores diferentes plis:)");
            Console.WriteLine("pon el valor 1 owo");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora el valor 2 ;)");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y ya el valor 3 *w*");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                //verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("el 1 es mayor,me va a dar una maldita sr *~*");
                    if (num2 > num3)
                    {
                        Console.WriteLine("vv el orden de los numeros es: " + num1 + " *w* " + num2 + " *w* "+num3);  
                    }
                }
            }
        }
    }
}
