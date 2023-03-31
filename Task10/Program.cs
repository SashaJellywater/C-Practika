// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
//                              *** Моё решение ***
int SecondDigit(int num)
{
    int noHundreds = num % 100;
    int noDozens = num % 10;
    int sec = (noHundreds - noDozens) / 10;
    return sec;
}

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа: {secDigit}");
}
else
{
    Console.WriteLine($"Число {number} не трёхзначное");
}

