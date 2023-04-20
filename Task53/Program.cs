// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
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
void ChangePlace(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[firstRow, i];
        matrix[firstRow, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}
int[,] newMatrix = CreateMatrixRndInt(4, 4, 1, 100);
PrintMatrix(newMatrix);
ChangePlace(newMatrix);
Console.WriteLine("изменённый массив");
PrintMatrix(newMatrix);