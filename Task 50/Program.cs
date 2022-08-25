/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] CreateMatrixRndInt(int str, int col, int min, int max)
{
    int[,] matrix = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");// 4- задает длинну под вывод 
        }
        Console.WriteLine();
    }
}

void ElementPos(int[,] matrix, int i, int j)
{
    if (i<matrix.GetLength(0) && j<matrix.GetLength(1))
        Console.WriteLine(matrix[i,j]);
    else
        Console.WriteLine("this position isn't in the array");
}

int[,] matr = CreateMatrixRndInt(5,5,0,20);
Console.Write("Enter string position: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column position: ");
int c = Convert.ToInt32(Console.ReadLine());
PrintMatrix(matr);
ElementPos(matr,s,c);
