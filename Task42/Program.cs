// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 ->10

int Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int DecToBin(int number)
{
    int y = 1;
    int duoNumber = 0;
    while (number != 0)
    {
        int xnum = number % 2;
        number = number / 2;
        xnum = xnum * y;
        y = y * 10;
        duoNumber = duoNumber + xnum;
    }
    return duoNumber;
}
string DecToBinStr(int number)
{
    string temp = string.Empty;
    while (number != 0)
    {
        temp = number % 2 + temp;
        number /= 2;
    }
    return temp;
}

int userNumber = Prompt("Введите целое число - ");
int duoNumberNew = DecToBin(userNumber);
string result = DecToBinStr(userNumber);
Console.WriteLine($"{userNumber} -> {duoNumberNew}");
Console.WriteLine(result);