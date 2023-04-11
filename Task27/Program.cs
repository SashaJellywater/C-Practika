// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int userNumber)
{
    if (userNumber < 0)
    {
        userNumber *= (-1);
    }
    int sum = 0;
    while (userNumber > 0)
    {
        sum += userNumber % 10;
        userNumber /= 10;
    }
    return sum;
}
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число - ");
int result = SumNumbers(number);
Console.WriteLine($"Сумма всех цифр числа {number} = {result}");