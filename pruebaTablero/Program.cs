using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de filas (N):");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número de columnas (M):");
        int m = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0 && m % 2 == 0)
        {
            int[,] tablero = PintarTablero(n, m);

            MostrarTablero(tablero);
        }
        else
        {
            Console.WriteLine("No es posible pintar el tablero con igual cantidad de espacios rojos y azules cumpliendo las restricciones.");
        }
    }

    static int[,] PintarTablero(int filas, int columnas)
    {
        int[,] tablero = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                // Pintar alternando rojo (0) y azul (1)
                tablero[i, j] = (i + j) % 2;
            }
        }

        return tablero;
    }

    static void MostrarTablero(int[,] tablero)
    {
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                // Mostrar en consola con colores
                Console.ForegroundColor = (tablero[i, j] == 0) ? ConsoleColor.Red : ConsoleColor.Blue;
                Console.Write(tablero[i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}