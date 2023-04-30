// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
bool IsCanMatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) return true;
    else return false;
}
int[,] MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMultiMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                newMultiMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return newMultiMatrix;
}

int[,] firstUserMatrix = CreateMatrixRndInt(4, 5, 2, 5);
int[,] secondUserMatrix = CreateMatrixRndInt(5, 3, 2, 5);
bool result = IsCanMatrixMultiply(firstUserMatrix, secondUserMatrix);
Console.WriteLine("Умножим матрицу : ");
PrintMatrix(firstUserMatrix);
Console.WriteLine("на матрицу : ");
PrintMatrix(secondUserMatrix);
if (result == true)
{
    int[,] resultMatrix = MatrixMultiply(firstUserMatrix, secondUserMatrix);
    Console.WriteLine("результирующая матрица =  ");
    PrintMatrix(resultMatrix);
}
else
    Console.WriteLine("Невозможно перемножить матрицы");