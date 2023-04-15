// Задача 51 Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали(с индексами(0,0);(1,1))
int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
       Console.WriteLine();
    }
}
int SumElemets(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i==j) sum +=matrix[i,j];
        }
    }
    return sum;
}
int FastSumElemets(int[,] matrix)
{
    int totalsum = 0;
    // int MaxDemention = matrix.GetLength(0);
    // if(MaxDemention>matrix.GetLength(1)) MaxDemention= matrix.GetLength(1);
        for (int j = 0; j < matrix.GetLength(1)&& j<matrix.GetLength(0); j++)
        {
        totalsum +=matrix[j,j];
        }
    return totalsum;
}
int userRows = Prompt("Задайте количество строк массива - ");
int userColumns = Prompt("Задайте количество столбцов массива - ");
int minimum = Prompt("Значение минимального элемента - ");
int maximum = Prompt("Значение максимального элемента - ");
int[,] userMatrix = CreateMatrixInt(userRows,userColumns, minimum, maximum);
PrintMatrix(userMatrix);
  // int result = SumElemets(userMatrix);
int result = FastSumElemets(userMatrix);
Console.WriteLine ($" Cумма элементов находящихся на главной диагонали = {result}");
