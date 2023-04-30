// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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
int[] MinElementOfMatrix(int[,] matrix)
{
    int[] index = new int[] { 0, 0 };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[index[0], index[1]])
            {
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}
int[,] RemoveRowColMinElement(int[,] matrix, int[] arr)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == arr[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == arr[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] userMatrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(userMatrix);
Console.WriteLine();
int[] indexArray = MinElementOfMatrix(userMatrix);
int[,] removeMatrix = RemoveRowColMinElement(userMatrix, indexArray);
PrintMatrix(removeMatrix);