using System;


namespace _4.condicionalessimpledoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL SIMPLES 
            //Simples
            //1.Crea un algoritmo que lea la edad del ususario y diga " bienvenido a mi sitio web" si el usuario es mayor de 18 se muestra 
            /* byte edad = 0;
             Console.WriteLine("ingrese su edad");
             edad = Convert.ToByte(Console.ReadLine());
             if (edad >= 18) 
             {
                 //Si la condición es verdadera, se ejecuta el bloque  de codigo dentro del if 
                 Console.WriteLine("bienvenido a mi sitio web");
             }*/
            //crear un algoritmo que érmita ingresar el nombre y el sueldo de una persona si el sueldo de la persona supera los 3000 pesos mostrarel mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
            string nombre;
            float sueldo = 0;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = Convert.ToUInt32(Console.ReadLine());
            if (sueldo == 0) ;
            {
                Console.WriteLine(" usted debe abonar impuestos");
            }
           //dvhvdskgjgjjhsf
            byte edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si se cumple la condición
                Console.WriteLine("bienvenido a mi sitio web");
            }
            else
            {
                //si NO se cumple
                Console.WriteLine("debe de tener minimo 18 para ingresar");
            }

        }
    }
}

