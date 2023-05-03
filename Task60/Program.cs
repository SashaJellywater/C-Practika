// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
bool IsMatrixCorrect(int[,,]matrix)
{
    if (matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2)<=90) return true;
    else return false;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) | ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] CreateMatrixRndInt(int row, int column, int depth, int min, int max)
{
    int[,,] mat = new int[row, column, depth];
    Random rnd = new Random();
    int rowLen = mat.GetLength(0);//
    int colLen = mat.GetLength(1);//Сделала для упрощения понимания при написании(для себя)
    int depLen = mat.GetLength(2);//
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
            for (int k = 0; k < depLen; k++)
            {
                int temp = rnd.Next(min, max);
                int count = 0;
                if (i == 0 && j == 0 && k == 0)
                {
                    mat[i, j, k] = temp;
                }
                else
                {
                    for (int e = 0; e < rowLen; e++)
                    {
                        for (int l = 0; l < colLen; l++)
                        {
                            for (int n = 0; n < depLen; n++)
                                if (temp == mat[e, l, n])
                                    count++;
                        }
                    }
                    if (count != 0)
                        temp = rnd.Next(min, max);
                    else
                    {
                        mat[i, j, k] = temp;
                    }
                }
            }
        }
    }
    return mat;
}
int[,,] array = CreateMatrixRndInt(4, 3, 4, 10, 100);
bool result = IsMatrixCorrect(array);
if(result==true) PrintMatrix(array);
else Console.WriteLine("Невозможно создать массив такого размера из неповторяющихся двузначных чисел");
