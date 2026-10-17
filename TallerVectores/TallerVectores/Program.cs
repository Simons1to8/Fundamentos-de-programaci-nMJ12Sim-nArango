using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i+1},I{i}");
                numeros[i] = int.Parse(Console.ReadLine());

                int menor = numeros[0];
                int mayor = numeros[0];

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine($"El numero mayor es: {mayor}, el numero menor es: {menor}");*/

            /*int[] columna1 = new int[3];
            int[] columna2 = new int[3];
            int contador = 0;

            for (int i = 0; i < columna1.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i + 1},I{i} de la primera ronda");
                columna1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese el numero P{i + 1},I{i} de la segunda ronda");
                columna2[i] = int.Parse(Console.ReadLine());

                if (columna1[i] == columna2[i])
                {
                    contador++;
                }
            }
            for (int i = 0; i < columna1.Length; i++)
            {
                Console.WriteLine($"P{i + 1},I{i} {columna1[i]}||{columna2[i]}");
            }
            Console.WriteLine($"La cantidad de numeros que son iguales es de: {contador}");*/

            /*Random numero = new Random();
            int[] num = new int[20];
            float promedio = 0f;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = numero.Next(-100, 99);
                promedio += num[i];
            }
            promedio /= 20f;
            Console.WriteLine($"EL promedio es:{promedio}");*/

            int[] arrA = new int[10];
            int[] arrB = new int[10];
            int totalCoincidentes = 0;

            for (int idx = 0; idx < 10; idx++)
            {
                Console.Write($"Digite el valor {idx + 1} para el arreglo A: ");
                arrA[idx] = int.Parse(Console.ReadLine());
            }

            for (int idx = 0; idx < arrB.Length; idx++)
            {
                Console.Write($"Digite el valor {idx + 1} para el arreglo B: ");
                arrB[idx] = int.Parse(Console.ReadLine());

                if (arrA[idx] == arrB[idx])
                {
                    totalCoincidentes++;
                }
            }

            Console.WriteLine($"Total de elementos idénticos en la misma posición: {totalCoincidentes}");
        }
    }
}