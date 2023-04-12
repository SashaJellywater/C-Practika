// Задайте одномерный массив из 123 случайных чисел
// Найдите количество элементов массива, значение которых лежат в отрезке от 10 до 99
int Prompt(string message)
{
    Console.WriteLine(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
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
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int FindElements(int[] arr, int min, int max)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i]>=min && arr[i]<=max) count +=1; 
    }
    return count;
}

int sizeArray = Prompt("Введите количество элиментов массива");
int minElement = Prompt("Введите минимальное значение элиментов массива");
int maxElement = Prompt("Введите максимальное значение элиментов массива");
int[] array = CreateArrayRndInt(sizeArray, minElement, maxElement);
PrintArray(array);
Console.WriteLine("Введите минимальное значение элементов");
int numberMinimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов");
int numberMaximum = Convert.ToInt32(Console.ReadLine());
int result = FindElements(array, numberMinimum, numberMaximum);
Console.WriteLine($"Количество элементов массива в отрезке от {numberMinimum} до {numberMaximum} = {result}");