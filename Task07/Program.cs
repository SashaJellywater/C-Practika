// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает
// последнюю цифру этого числа.
Console.WriteLine("введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.WriteLine($"Последняя цифра числа: {lastNumber}");
}
else
{
    Console.WriteLine($"Число {number} не трёхзначное");
}