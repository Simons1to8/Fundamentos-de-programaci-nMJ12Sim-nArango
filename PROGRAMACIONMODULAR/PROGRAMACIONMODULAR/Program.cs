using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACIONMODULAR
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("helouuu");
            MostrarMensaje("ferney ");
            MostrarMensaje("juan");
            Console.ReadKey();
            BorrarPantalla();
        }
        //Procedimiento sin parámetros
        static void Main()
        {
            Console.WriteLine("bienvenido");
            MostrarMensaje("ale");
            MostrarMensaje("francisco", "YAAAAAA");
     
            Console.ReadKey();
            BorrarPantalla();

            Console.WriteLine($"POPO tiene {CalcularEdad()}");
            Console.WriteLine($"FRANCISCO YAAAA tiene {CalcularEdad(2026, 1822)}");
        }
        //Procedimiento sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }

        static int CalcularEdad()
        {
            int añoActual = 2026;
            int añoNacimiento = 1822;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        //Procedimiento con parámetros
        static void MostrarMensaje(string nombre)
        {

            Console.WriteLine($"ferney: {nombre}");

        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Daniel: {nombre} {apellidos}");
        }
    }
}


