// Задача44 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи : 0 и 1.
// Если N = 5 -> 0, 1, 1, 2, 3
// Если N = 5 -> 0, 1, 1,
// Если N = 7 -> 0, 1, 1, 2, 3, 5, 8

int Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int[] CreateArrayFib(int size)
{
    int[] arr = new int[size];
    arr[0]=0;
    arr[1]=1;
    for (int i = 2; i < size ; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
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
int length = Prompt("длина массива - ");
PrintArray(CreateArrayFib(length));