using System;
using System.Diagnostics.Eventing.Reader;

namespace _5.CondicionalesAnidaos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales anidados 
            //Diseñar un algoritmo que lea tres numeros a,b,c y visualice en pantalla el valor mas grande . el usuario debe ingresar 3 valores diferentes
            int num1 = 0;
            int num2=0;
            int num3=0;
            Console.WriteLine("por favor ingrese 3 valores diferentes");
            Console.WriteLine("ingrese valor numero 1");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valos del numero 2");
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 3");
            num3=int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                // Verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("el numero 1 es mayor");
                }
                else
                {
                    Console.WriteLine("el numero 3 es mayor");
                }

            }
            else
            {
                //falsa
                if (num2 > num3) 
                {
                    Console.WriteLine("el numero 2 es mayor");
                }
                else
                {
                    Console.WriteLine("el numero 3 es mayor");
                }


            }
        } 
    }
}
