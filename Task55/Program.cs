﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

//  универсальное решение
// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] arr = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(min, max);
//         }
//     }
//     return arr;
// }
// void PrintMatrix(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceElementMatrix(int[,] matrix)
// {
//     int[,] resultMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             resultMatrix[j, i] = matrix[i, j];
//         }
//     }
//     return resultMatrix;
// }

// int[,] userMatrix = CreateMatrixRndInt(3, 4, 1, 100);
// Console.WriteLine("исходный массив");
// PrintMatrix(userMatrix);
// Console.WriteLine("изменённый массив");
// int[,] result = ReplaceElementMatrix(userMatrix);
// PrintMatrix(result);

// Решение только для квадратных массивов
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
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}
bool IsMatrixQuatro(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else return false;
}
int[,] ReplaceElementMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
        }
    }
    return matrix;
}

int[,] userMatrix = CreateMatrixRndInt(5, 5, 1, 100);
Console.WriteLine("исходный массив");
PrintMatrix(userMatrix);
bool result = IsMatrixQuatro(userMatrix);
if (result == true)
{
    ReplaceElementMatrix(userMatrix);
    Console.WriteLine("изменённый массив");
    PrintMatrix(userMatrix);
}
else
    Console.WriteLine("невозможно изменить массив");