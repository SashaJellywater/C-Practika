﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int Prompt(string message)
{
    Console.WriteLine(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
void NaturalNumbers(int num)
{
    if(num == 0)return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
int number = Prompt("Введите положительное целое число");
if(number>0)
    NaturalNumbers(number);
    else
    Console.WriteLine("Некорректный ввод");