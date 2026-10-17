using System;
using System.Linq;

namespace TallerPModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrizJuego = new char[3, 3];

            ArmarTablero(matrizJuego);

            char turnoActual = 'X';
            bool hayGanador = false;

            while (!hayGanador && !EspaciosAgotados(matrizJuego))
            {
                PintarTablero(matrizJuego);

                Console.WriteLine("Turno para el participante " + turnoActual);
                Console.WriteLine("Selecciona un número del 1 al 9:");

                if (!int.TryParse(Console.ReadLine(), out int casilla)
                    || casilla < 1 || casilla > 9)
                {
                    Console.WriteLine("Opción no válida. Prueba de nuevo.");
                    continue;
                }

                int r = (casilla - 1) / 3;
                int col = (casilla - 1) % 3;

                if (!MarcarCasilla(matrizJuego, r, col, turnoActual))
                {
                    Console.WriteLine("Esa casilla ya está ocupada. Escoge otra.");
                    continue;
                }
                hayGanador = ComprobarVictoria(matrizJuego, turnoActual);

                if (!hayGanador)
                {
                    turnoActual = (turnoActual == 'X') ? 'O' : 'X';
                }
            }

            PintarTablero(matrizJuego);

            if (hayGanador)
            {
                Console.WriteLine("¡Excelente! Ha ganado el participante " + turnoActual);
            }
            else
            {
                Console.WriteLine("¡Empate técnico! Ya no quedan casillas libres.");
            }
        }

        static void ArmarTablero(char[,] matrizJuego)
        {
            char casillaNum = '1';

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    matrizJuego[f, c] = casillaNum;
                    casillaNum++;
                }
            }
        }

        static void PintarTablero(char[,] matrizJuego)
        {
            Console.WriteLine("\nTablero de juego:");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(" " + matrizJuego[f, c] + " ");

                    if (c < 2)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine();

                if (f < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }

            Console.WriteLine();
        }

        static bool MarcarCasilla(
            char[,] matrizJuego, int f, int c, char turnoActual)
        {
            if (matrizJuego[f, c] == 'X'
                || matrizJuego[f, c] == 'O')
            {
                return false;
            }

            matrizJuego[f, c] = turnoActual;
            return true;
        }

        static bool ComprobarVictoria(char[,] matrizJuego, char turnoActual)
        {
            for (int f = 0; f < 3; f++)
            {
                if (matrizJuego[f, 0] == turnoActual
                    && matrizJuego[f, 1] == turnoActual
                    && matrizJuego[f, 2] == turnoActual)
                {
                    return true;
                }
            }

            for (int c = 0; c < 3; c++)
            {
                if (matrizJuego[0, c] == turnoActual
                    && matrizJuego[1, c] == turnoActual
                    && matrizJuego[2, c] == turnoActual)
                {
                    return true;
                }
            }

            if (matrizJuego[0, 0] == turnoActual
                && matrizJuego[1, 1] == turnoActual
                && matrizJuego[2, 2] == turnoActual)
            {
                return true;
            }

            if (matrizJuego[0, 2] == turnoActual
                && matrizJuego[1, 1] == turnoActual
                && matrizJuego[2, 0] == turnoActual)
            {
                return true;
            }

            return false;
        }

        static bool EspaciosAgotados(char[,] matrizJuego)
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (matrizJuego[f, c] != 'X'
                        && matrizJuego[f, c] != 'O')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}