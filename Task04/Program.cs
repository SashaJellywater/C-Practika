// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье целое число");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

Console.Write($"max = {max}");