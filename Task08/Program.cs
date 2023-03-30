// // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите положительноне целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (number == 1)
{
    Console.WriteLine("Для числа 1  нет чётных чисел в диапазоне от 0");
}
if (number < 1)
{
    Console.WriteLine("Ошибка! Попробуйте ввести ПОЛОЖИТЕЛЬНОЕ число");
}

while (count <= number)
{
    if (count % 2 == 0)
        Console.Write($"{count} ");
    ;
    count++;
}