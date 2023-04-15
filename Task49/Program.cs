// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные
// и замените эти элементы на их квадраты.
//  1 4 7 2        1  4  49 2
//  5 9 2 3 ->>>   5  9  2  3
//  8 4 2 4        64 4  4  4
int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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
void ReplaceToSquaresElemets(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+= 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+= 2)
        {
            matrix[i, j] *= matrix[i, j];  //   if (i%2==0 && j%2==0) 
        }
    }
}

int userRows = Prompt("Задайте количество строк массива - ");
int userColumns = Prompt("Задайте количество столбцов массива - ");
int minimum = Prompt("Значение минимального элемента - ");
int maximum = Prompt("Значение максимального элемента - ");
int[,] userMatrix = CreateMatrixInt(userRows, userColumns, minimum, maximum);
PrintMatrix(userMatrix);
ReplaceToSquaresElemets(userMatrix);
Console.WriteLine("Массив с квадратами значений");
PrintMatrix(userMatrix);
