using System;


namespace TallerCONDICIONALES
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("¡Ey! Ingresaste números iguales, debes poner valores diferentes >:c");
            }
            else
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("el 1 es mayor,me va a dar una maldita sr *~*");
                        if (num2 > num3)
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num3 + " *w* " + num2 + " *w* " + num1);
                        }
                        else
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num2 + " *w* " + num3 + " *w* " + num1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("el 3 es el mayor owo");
                        if (num1 > num2)
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num2 + " *w* " + num1 + " *w* " + num3);
                        }
                        else
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num1 + " *w* " + num2 + " *w* " + num3);
                        }
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("el 2 es mayor *~*");
                        if (num1 > num3)
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num3 + " *w* " + num1 + " *w* " + num2);
                        }
                        else
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num1 + " *w* " + num3 + " *w* " + num2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("el 3 es mayor *w*");
                        if (num2 > num1)
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num1 + " *w* " + num2 + " *w* " + num3);
                        }
                        else
                        {
                            Console.WriteLine("vv el orden de los numeros es: " + num2 + " *w* " + num1 + " *w* " + num3);
                        }
                    }
                }
            }
        }
    }
}