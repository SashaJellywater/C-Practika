// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д
// [1, 2, 3, 4, 5] -> 5 8 3
//[6, 3, 7, 9] -> 54 21
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
    Console.WriteLine("]");
}

int[] NewArray(int[] arr)
{
    int newSize = arr.Length / 2;
    if (arr.Length % 2 != 0)
    {
        newSize += 1;
    }
    int[] find = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        find[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) find[newSize - 1] = arr[arr.Length / 2];
    return find;
}

int newArraySize = Prompt("Укажите размер массива");
int minElement = Prompt("Укажите минимальное значение для элемента массива");
int maxElement = Prompt("Укажите максимальное значение для элемента массива");
int[] userArray = CreateArrayRndInt(newArraySize, minElement, maxElement);
int[] productArray = NewArray(userArray);
PrintArray(userArray);
Console.Write(" -> ");
PrintArray(productArray);