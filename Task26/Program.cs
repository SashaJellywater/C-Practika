// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Counter(int userNumber)
{
    int i = 0;
    while (userNumber != 0)
    {
        i++;
        userNumber = userNumber / 10;
    }
    return i;
}

int number = Prompt("Введите число ");
int result = Counter(number);
Console.WriteLine($"В числе {number}  количество цифр = {result}");