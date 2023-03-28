//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("введите первое целое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число");
int second_number = Convert.ToInt32(Console.ReadLine());
if (first_number == second_number * second_number)
{
Console.WriteLine($"число {first_number} является квадратом числа {second_number}");
}
else 
{
Console.WriteLine($"число {first_number} не является квадратом числа {first_number}");
}