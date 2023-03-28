// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if(number %2 == 0)
{
    Console.WriteLine($"число {number} является чётным");
}
else
{
    Console.WriteLine($"число {number} не является чётным");
}