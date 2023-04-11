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
    find[newSize-1]= arr[arr.Length/2];
    return find;
}

int si = Prompt("размер");
int mi = Prompt("mini");
int ma = Prompt("maxi");
int[] arrr = CreateArrayRndInt(si, mi, ma);
int[] prod = NewArray(arrr);
PrintArray(arrr);
Console.Write(" -> ");
PrintArray(prod);