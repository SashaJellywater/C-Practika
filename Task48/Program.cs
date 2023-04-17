//  Задайте двумерный массив размера m на n,
// каждый элемент которого находится по формуле Amn = m+n.
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int userRows = Prompt("Задайте количество строк массива");
int userColumns = Prompt("Задайте количество столбцов массива");
int[,] result = CreateMatrixInt(userRows, userColumns);
PrintMatrix(result);