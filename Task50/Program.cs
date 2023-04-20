// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого элемента в массиве нет
int Prompt(string message)
{
    Console.Write(message);
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
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}
bool IsElementExist(int[,] matrix, int rowIndex, int columnIndex)
{
    if (0 <= rowIndex && rowIndex < matrix.GetLength(0) && 0 <= columnIndex && columnIndex < matrix.GetLength(1)) return true;
    else return false;
}
// int userRow = Prompt("Введите количество строк массива - ");
// int userColumns = Prompt("Введите количество столбцов массива - ");
// int minimum = Prompt("Введите минимальное значение элемента массива- ");
// int maximum = Prompt("Введите максимальное значение элемента массива - ");
// int[,] newArray = CreateMatrixRndInt(userRow, userColumns, minimum, maximum);
int[,] newArray = CreateMatrixRndInt(6, 5, -5, 5);
PrintMatrix(newArray);
int firstIndex = Prompt("Введите позицию строки - ");
int secondIndex = Prompt("Введите позицию столбца - ");
bool result = IsElementExist(newArray, firstIndex, secondIndex);
Console.WriteLine(result ? $"Элемент массива на позиции [{firstIndex},{secondIndex}] = {newArray[firstIndex, secondIndex]}" : "Нет элемента с заданной позицией.");