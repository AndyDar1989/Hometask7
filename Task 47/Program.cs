/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] CreateMatrixRndDouble(int str, int col, double min, double max)
{
    double[,] matrix = new double[str, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],7}");// 4- задает длинну под вывод 
        Console.WriteLine();
    }
}

Console.Write("Enter count of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matr = CreateMatrixRndDouble(m, n, -100.0, 100.0);
PrintMatrix(matr);
