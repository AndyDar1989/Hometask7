/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateMatrixRndInt(int str, int col, int min, int max)
{
    int[,] matrix = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4}");// 4- задает длинну под вывод 
        Console.WriteLine();
    }
}

void AverageValueCol(int[,] matrix)
{
    Console.Write("The average of every column: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int size = matrix.GetLength(0);
        int sum = 0;
        for (int i = 0; i < size; i++)
            sum += matrix[i, j];
        if (j < matrix.GetLength(1) - 1)
            Console.Write($"{Math.Round((double)sum / size, 1)};  ");
        else Console.Write($"{Math.Round((double)sum / size, 1)}.");
    }
}

int[,] matr = CreateMatrixRndInt(5, 5, 0, 9);
PrintMatrix(matr);
AverageValueCol(matr);
