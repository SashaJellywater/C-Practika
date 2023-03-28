// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if(number %2 == 0)
{
    Console.WriteLine($" Ура! число {number} чётное");
}
else
{
    Console.WriteLine($" О нет! число {number} нечётное");
}