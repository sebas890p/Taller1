using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { -5,  2, -3 },
            {  4, -1,  6 },
            { -7,  8, -9 }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        ReemplazarNegativos(matriz);

        Console.WriteLine("\nMatriz con valores positivos:");
        ImprimirMatriz(matriz);

        Console.WriteLine("\nPromedio de cada fila:");
        CalcularPromedioFilas(matriz);

        Console.WriteLine("\nPromedio de cada columna:");
        CalcularPromedioColumnas(matriz);
    }

    static void ReemplazarNegativos(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = Math.Abs(matriz[i, j]);
                }
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void CalcularPromedioFilas(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            int suma = 0;
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
            double promedio = (double)suma / columnas;
            Console.WriteLine($"Fila {i + 1}: {promedio:F2}");
        }
    }

    static void CalcularPromedioColumnas(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int j = 0; j < columnas; j++)
        {
            int suma = 0;
            for (int i = 0; i < filas; i++)
            {
                suma += matriz[i, j];
            }
            double promedio = (double)suma / filas;
            Console.WriteLine($"Columna {j + 1}: {promedio:F2}");
        }
    }
}
