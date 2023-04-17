// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}
void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 1, MidpointRounding.ToZero),4} | ");
        }
        Console.WriteLine();
    }
}

int userRows = Prompt("Задайте количество строк массива - ");
int userColumns = Prompt("Задайте количество столбцов массива - ");
int minimum = Prompt("Значение минимального элемента - ");
int maximum = Prompt("Значение максимального элемента - ");
double[,] userMatrix = CreateMatrixInt(userRows, userColumns, minimum, maximum);
PrintDoubleMatrix(userMatrix);