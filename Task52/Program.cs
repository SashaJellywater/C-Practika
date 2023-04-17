// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max);
        }
    }
    return arr;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 2, MidpointRounding.ToZero)},  ");
        else Console.Write($"{Math.Round(arr[i], 2, MidpointRounding.ToZero)}");
    }
    Console.Write("]");
}
double[] FindColumnsElements(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    int k = 0;
    int columns = matrix.GetLength(1);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arr[k] = matrix[0, j];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            arr[k] += matrix[i, j];
        }
        arr[k] /= matrix.GetLength(0);
        k++;
    }
    return arr;
}

int[,] newmatrix = CreateMatrixRndInt(3, 4, -9, 10);
PrintMatrix(newmatrix);
double[] newarrayus = FindColumnsElements(newmatrix);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
PrintArrayDouble(newarrayus);