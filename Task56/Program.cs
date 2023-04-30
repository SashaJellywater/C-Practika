// Задача 56: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}
int[] SumRowElements(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int k = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        arr[k] = matrix[j, 0];
        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            arr[k] += matrix[j, i];
        }
        k++;
    }
    return arr;
}
int WhichMinimumRow(int[] arr)
{
    int minIndex = 0;
    int minElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
            minIndex = i;
        }
    }
    return minIndex;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[,] newMatrix = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(newMatrix);
int[] sumArray = SumRowElements(newMatrix);
PrintArray(sumArray);  // Вывод массива происходит для упрощения проверки результата
int minRowNumber = WhichMinimumRow(sumArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов = {minRowNumber}");