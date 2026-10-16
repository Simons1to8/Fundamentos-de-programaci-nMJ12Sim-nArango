using System;

namespace CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();
            int numero = generador.Next(1, 101);
            int intento = 0;

            while (intento != numero)
            {
                Console.WriteLine("El programa ha elegido un número entre 1 y 100 ,bruh, intente adivinarlo");
                intento = int.Parse(Console.ReadLine());

                if (intento > numero)
                {
                    Console.WriteLine("eso mayor al número, you stupid");
                }
                else if (intento < numero)
                {
                    Console.WriteLine(" es menor al número _-_");
                }
            }
            Console.WriteLine($"Casi que no, el número era {intento}");


        }
    }
}