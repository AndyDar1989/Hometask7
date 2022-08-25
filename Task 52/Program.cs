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

double[] AverageColValue(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] array = new double[size];
    int k = 0;
    int j =0;
    int sum = 0;
    while(j<size)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        sum+=matrix[i,j];
        }
        double average = sum/size*1.0;
        array[k] = average;
        j++;
        k++;
    }
    return array;
}

int[,] matr = CreateMatrixRndInt(3,4,0,9);
PrintMatrix(matr);
double[] av = AverageColValue(matr);
Console.WriteLine(av);