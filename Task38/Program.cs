// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)},  ");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}");
    }
    Console.Write("]");
}
double FindMaxElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    return maxElement;
}
double FindMinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    return minElement;
}
double FindDifference(double minNumber, double maxNumber)
{
    double dif = maxNumber - minNumber;
    return dif;
}
double[] array = CreateArrayRndDouble(5, 2, 9);
double max = FindMaxElement(array);
double min = FindMinElement(array);
double difference = FindDifference(min, max);
PrintArrayDouble(array);
Console.Write($" -> {Math.Round(difference, 1, MidpointRounding.ToZero)}");