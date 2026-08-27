using System;


namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int numero = 0;
            // int contador = 0;
            //int cantidad = 0;
            // int contadorPositivi = 0;
            //int contadornegativo = 0;
            // int contadorceros = 0;

            // Console.WriteLine("ingrese la cantidad de números que va introducir");
            // cantidad = int.Parse(Console.ReadLine());


            // while (contador < cantidad)
            {
                //contador++;
                // Console.WriteLine("Ingrese el número a evaluar");
                // numero = int.Parse(Console.ReadLine());
                // if (numero > 0)
                {
                    // contadorPositivi++;
                }
                // else 
                {
                    //if(numero<0)
                    {
                        //contadornegativo++;
                    }
                    // else
                    {
                        //contadorceros++;
                    }
                }

                // Console.WriteLine($"Cantidad de positivos:{contadorPositivi}, cantidad de megativos: {contadornegativo}, cantidad de 0: {contadorceros}");


                int contadordepares = 0;
                int contador = 1;
                int rango = 0;

                Console.WriteLine(" ingrese el rango de numeros que quiere evaluar");
                rango = int.Parse(Console.ReadLine());

                while(contador<=rango )
                {
                    if (contador % 2 == 0) 
                    {
                        contadordepares++;
                        Console.WriteLine($"{contador} - ");
                    }
                    contador++;
                }

                Console.WriteLine($"La cantidad de numeros pares en el rango del 1 al {rango} es: {contadordepares}");
                
            }
           
        }
    }
}
