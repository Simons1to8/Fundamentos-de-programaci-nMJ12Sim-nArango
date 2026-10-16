using System;
namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            int NroCuenta;
            float saldo;
            string continuar;

            int contador = 0;
            double acumulador = 0;


            do
            {
                Console.WriteLine("Ingrese el nombre ");
                nombre = Console.ReadLine();

                Console.WriteLine("el número de cuenta");
                NumeroCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Pon el saldo:");
                saldo = float.Parse(Console.ReadLine());

                contador++;
                acumulador = acumulador + saldo;

                if (saldo >= 3000000)
                {
                    Console.WriteLine("Nombre: " + nombre);

                    Console.WriteLine("Número de cuenta: " + NroCuenta);

                    Console.WriteLine("Saldo: " + saldo);

                    Console.WriteLine("Es apto para el Crédito :)");

                }
                else
                {
                    Console.WriteLine("Nombre: " + nombre);

                    Console.WriteLine("Número de cuenta: " + NroCuenta);

                    Console.WriteLine("Saldo: " + saldo);

                    Console.WriteLine("No es apto para el crédito :(");
                }
                Console.WriteLine();
                Console.Write("Desea ingresar otro usuario? (si/no)hp");
                continuar = Console.ReadLine();

            } while (continuar == "si");

            double promedio = acumulador / contador;
            Console.WriteLine();
            Console.WriteLine("Número de usuarios: " + contador);
            Console.WriteLine("Promedio de saldos: " + promedio);

        }
    }
}