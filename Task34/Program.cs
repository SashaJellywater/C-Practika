// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int FindEvenNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}
int[] newArray = CreateArrayRndInt(5, 100, 999);
int result = FindEvenNumber(newArray);
PrintArray(newArray);
Console.Write($" -> {result}");

// // *  С пользовательским массивом:
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int userNumber = Convert.ToInt32(Console.ReadLine());
//     return userNumber;
// }
// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }
// int FindEvenNumber(int[] array)
// {
//     int count = 0;

//     for(int i =0; i<array.Length;i++)
//     { 
//         if(array[i] %2 == 0) count+=1;
//     }
//     return count;
// }
// int newArraySize = Prompt("Укажите размер массива");
// int minElement = Prompt("Укажите минимальное значение для элемента массива");
// int maxElement = Prompt("Укажите максимальное значение для элемента массива");
// int [] newArray = CreateArrayRndInt(newArraySize, minElement, maxElement);
// bool IsNumberThreeDigit(int firstNumber, int secondNumber)
// {
//     if 
//         ((firstNumber>99 && firstNumber<1000 || firstNumber<-99 && firstNumber > -1000) && (secondNumber>99 && secondNumber<1000 || secondNumber<-99 && secondNumber > -1000))
//         return true;
//     return false;
// }

// int result = FindEvenNumber(newArray);

// bool threeDigit = IsNumberThreeDigit(minElement,maxElement);
// if (threeDigit==false) Console.WriteLine("Неверные данные");
// else
// {
// PrintArray(newArray);
// Console.Write($" -> {result}");
// }