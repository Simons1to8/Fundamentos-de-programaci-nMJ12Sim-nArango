using System;


namespace CicloFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int inicioR;
            Console.WriteLine("Ingrese el incio del rango ");
            inicioR = int.Parse(Console.ReadLine());
            int finR;
            Console.WriteLine("Ingrese el final del rango ");
            finR = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los múltiplos de 5 entre {inicioR} y {finR} son:");

            for (int i = inicioR; i <= finR; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}