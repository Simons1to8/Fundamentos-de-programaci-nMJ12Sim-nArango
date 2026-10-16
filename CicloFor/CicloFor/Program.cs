using System;



namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            int numero;
            int factorl = 1;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                factorl = factorl * i;
            }

            Console.WriteLine("El fctrl de  " + numero + " es: " + factor);
        }
    }
}
