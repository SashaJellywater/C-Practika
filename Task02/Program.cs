// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, 
//а какое меньшее.

Console.WriteLine("введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber )
{
Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
}
else 
{
Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
}