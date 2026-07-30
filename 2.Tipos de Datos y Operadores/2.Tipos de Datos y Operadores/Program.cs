using System;


namespace _2.Tipos_de_Datos_y_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //constantes
            const string gravedad = "9.8";
            string nombre = "Simón";
            nombre = "Arango";
            //gravedad = "10"; no puedo cambair el valor de una constante

            //TIPOS DE DATOS 
            byte dato1 = 0;
            int dato2 = -4325;
            ulong dato3 = 72654746647362;
            float dato4 = 14.6f;
            double dato5 = 76857464588.67943987d;
            decimal dato6 = 12345678467.2345678765m;

            char dato7 = '~';
            string dato8 = "opiropiripiropi?¡!";
            bool dato9 = false;//true or false 
            object dato10 = new object();

            //OPERADORES 
            //operadores numericos
            //cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0},dato12:{1},dato13:{2},dato14:{3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3;//suma
            int dato16 = dato15 - 2;//resta
            int dato17 = 25 * 3;//producto
            float dato18 = (float)5 / 3;//división
            Console.WriteLine("Suma:{0},resta:{1},producto:{2},división{3}", dato15,dato16,dato17,dato18);






        }
    }
}
