int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] mat = new int[row, column];
    Random rnd = new Random();
    int rowLen = mat.GetLength(0);
    int colLen = mat.GetLength(1);
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
            int temp = rnd.Next(min, max + 1);
            int count = 0;
            if (i == 0 && j==0)
            {
                mat[i,j] = temp;
            }
            else
            {
                for (int e = 0; e < rowLen; e++)
                {
                    for(int k= 0;k<colLen;k++)
                    if (temp == mat[e,k])
                        count++;
                }
                if (count != 0)
                    temp = rnd.Next(min, max + 1);
                else
                {
                    mat[i,j] = temp;
                }
            }
        }
    }
    return mat;
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
int[,] array = CreateMatrixRndInt(2,2, 10, 100);
 PrintMatrix(array);