// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;

}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

bool FindElemInArray(int[]arr, int findNum)
{
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i] == findNum) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Введите число, которое будем искать в массиве: ");
int searchNum = Convert.ToInt32(Console.ReadLine());

bool result = FindElemInArray(array, searchNum);
Console.WriteLine(result?"да, есть такой элемент":"нет, нет такого элемента" );
// if(result) Console.WriteLine("да, есть такой элемент");
// else Console.WriteLine("нет, нет такого элемента");