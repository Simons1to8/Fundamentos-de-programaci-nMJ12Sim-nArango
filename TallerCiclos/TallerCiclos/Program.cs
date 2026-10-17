using System;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            /*
            int nota = 0;
            string continuar = "s";
            float sumaNotas = 0;
            int cantidad = 0;

            do
            {
                Console.Write("Digite una calificación: ");
                nota = int.Parse(Console.ReadLine());
                sumaNotas += nota;
                cantidad++;
                Console.Write("¿Desea añadir otra nota? (s para sí, cualquier otra tecla para no): ");
                continuar = Console.ReadLine();

            } while (continuar == "s");

            Console.WriteLine($"El promedio de las calificaciones es: {sumaNotas / cantidad}");
            */


            // ==========================================
            // EJERCICIO 2: Divisores de un número
            // ==========================================
            /*
            int num;

            Console.Write("Digite un número entero: ");
            num = int.Parse(Console.ReadLine());
            int divisor = 0;

            do
            {
                divisor++;
                if (num % divisor == 0)
                {
                    Console.WriteLine(divisor);
                }
            } while (divisor <= num);
            */


            // ==========================================
            // EJERCICIO 3: Potenciación
            // ==========================================
            /*
            int baseNum = 0;
            int exponente = 0;
            string respuesta = "s";
            
            do
            {
                Console.Write("Digite la base: ");
                baseNum = int.Parse(Console.ReadLine());
                Console.Write("Digite el exponente: ");
                exponente = int.Parse(Console.ReadLine());

                double resPotencia = Math.Pow(baseNum, exponente);

                Console.WriteLine($"La potencia del número {baseNum} es: {resPotencia}");

                Console.Write("¿Desea calcular otra potencia? (s para sí, cualquier otra tecla para no): ");
                respuesta = Console.ReadLine();

            } while (respuesta == "s");
            */


            // ==========================================
            // EJERCICIO 4: Evaluación del Atleta
            // ==========================================
            /*
            int minutosDia = 0;
            int sumaTiempos = 0;
            int dia = 1;
            float promMinutos = 0;
            bool esApto = true;
            bool tieneMenor15 = false;

            do
            {
                Console.Write($"Ingrese el tiempo registrado en el día {dia}: ");
                minutosDia = int.Parse(Console.ReadLine());

                sumaTiempos += minutosDia;
                promMinutos = (float)sumaTiempos / dia;

                if (minutosDia > 20)
                {
                    esApto = false;
                }
                if (minutosDia < 15)
                {
                    tieneMenor15 = true;
                }
                if (promMinutos > 18)
                {
                    esApto = false;
                }

                dia++;
            } while (esApto && dia <= 10);

            Console.WriteLine($"El promedio general es: {promMinutos}");

            if (!tieneMenor15)
            {
                esApto = false;
            }

            if (esApto)
            {
                Console.WriteLine("El atleta es apto");
            }
            else
            {
                Console.WriteLine("El atleta no es apto");
            }
            */
        }
    }
}