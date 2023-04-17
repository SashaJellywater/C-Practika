// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
int[] MatrixInArray(int[,]matrix)
{
    int[] resultArray = new int [matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultArray[k] = matrix[i,j];
            k++;
        }
    }
    return resultArray;
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
void DictionaryArrayElement(int[]arr)
{
    int count = 1;
    int currentNumb = arr[0];
    for(int i = 1; i<arr.Length; i++)
    {
        if (arr[i] == currentNumb) count++;
        else 
        {
            Console.WriteLine($" Число {currentNumb} встречается {count} раз.");
            currentNumb= arr[i];
            count =1;
        }
    }
 Console.WriteLine($" Число {currentNumb} встречается {count} раз.");
}

int[,] userMatrix = CreateMatrixRndInt(4,5,1,10);
PrintMatrix(userMatrix);
Console.WriteLine();
int[] newArray = MatrixInArray(userMatrix);
Array.Sort(newArray);
PrintArray(newArray);
Console.WriteLine();
DictionaryArrayElement(newArray);