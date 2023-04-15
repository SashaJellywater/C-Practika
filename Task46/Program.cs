// Задайте двумерный массив размером m*n,
// заполненный случайными целыми числами.
// m = 3, n = 4
// 1  4  8  19
// 5 -2  33 -2
// 77 3  8   1
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
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
        // Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        // Console.WriteLine(" ]");
        Console.WriteLine();
    }
}

int stroks = Prompt("Введите количество строк массива");
int stolbs = Prompt("Введите количество столбцов массива");
int minimum = Prompt("Введите минимальное значение элемента");
int maximum = Prompt("Введите максимальное значение элемента");
int[,] newArray = CreateMatrixRndInt(stroks, stolbs, minimum, maximum);
PrintMatrix(newArray);