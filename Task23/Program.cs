// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
    Console.WriteLine(message);
    int newNum = Convert.ToInt32(Console.ReadLine());
    while (newNum < 1)
    {
        Console.WriteLine("Неправильно! Введите положительное целое число");
        newNum = Convert.ToInt32(Console.ReadLine());
    }
    return newNum;
}

string Table(int numbers)
{
    string tableCell = " ________________\n";
    for (int count = 1; count <= numbers; count++)
    {
        tableCell = tableCell + $"|{count,6}  | {count * count * count,6}| \n";
    }
    return tableCell;
}

int num = Prompt("Введите положительное целое число");
string result = Table(num);
Console.Write(result);