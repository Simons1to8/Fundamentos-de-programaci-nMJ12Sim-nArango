using System;

namespace modulosEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesplegarMenu();
            ProcesarCalculo(ObtenerSeleccion());
        }

        static float Multiplicacion()
        {
            float val = 0;
            float totalMult = 1;
            char opt = ' ';
            do
            {
                Console.Write("Digite un valor: ");
                val = float.Parse(Console.ReadLine());
                totalMult *= val;
                Console.Write("¿Desea ingresar otro factor? (s para continuar): ");
                opt = char.Parse(Console.ReadLine());
            } while (opt == 's');
            return totalMult;
        }

        static float division()
        {
            Console.Write("Digite el numerador: ");
            float numA = float.Parse(Console.ReadLine());
            Console.Write("Digite el denominador: ");
            float numB = float.Parse(Console.ReadLine());
            return numA / numB;
        }

        static float resta()
        {
            Console.Write("Digite el minuendo: ");
            float val1 = float.Parse(Console.ReadLine());
            Console.Write("Digite el sustraendo: ");
            float val2 = float.Parse(Console.ReadLine());
            return val1 - val2;
        }

        static float suma()
        {
            float val = 0;
            float totalSuma = 0;
            char opt = ' ';
            do
            {
                Console.Write("Digite un valor: ");
                val = float.Parse(Console.ReadLine());
                totalSuma += val;
                Console.Write("¿Desea ingresar otro sumando? (s para continuar): ");
                opt = char.Parse(Console.ReadLine());
            } while (opt == 's');
            return totalSuma;
        }

        static void ProcesarCalculo(int opcionSeleccionada)
        {
            while (opcionSeleccionada != 0)
            {
                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine($"\nEl resultado de la suma es: {suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"\nEl resultado de la resta es: {resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"\nEl resultado de la multiplicación es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"\nEl resultado de la división es: {division()}");
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                DesplegarMenu();
                opcionSeleccionada = ObtenerSeleccion();
            }
        }

        static int ObtenerSeleccion()
        {
            return int.Parse(Console.ReadLine());
        }

        static void DesplegarMenu()
        {
            
            Console.WriteLine("     CALCULADORA        ");
            
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            
            Console.Write("Seleccione una opción: ");
        }
    }
}