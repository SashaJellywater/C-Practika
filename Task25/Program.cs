// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int UserNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.Write(message);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
int MathNumber(int first, int second)
{
    int prod = first;
    for (int i = 1; i < second; i++)
    {
        prod = prod * first;
    }
    return prod;
}
int firstNumber = UserNumber("введите положительное целое число - ");
int secondNumber = UserNumber("введите положительное целое число (степень) - ");
int result = MathNumber(firstNumber, secondNumber);
Console.WriteLine($"число {firstNumber} в степени {secondNumber} равно {result}");
// /// *** Эталонное решение***
// int Prompt(string message)
// {
//     Console.Write(message);
//     string readInput = Console.ReadLine();
//     int number = int.Parse(readInput);
//     return number;
// }
// int Power(int first, int second)
// {
//     int prod = 1;
//     for(int i = 0 ; i<second; i++)
//     {
//         prod *= first;
//     }
//     return prod;
// }
// bool ValidateExponent(int second)
// {
//     if (second<0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }
// int firstNumber = Prompt("введите положительное целое число - ");
// int secondNumber = Prompt("введите положительное целое число (степень) - ");
// int result = Power(firstNumber, secondNumber);
// if (ValidateExponent(secondNumber))
// {
//     Console.WriteLine($"число {firstNumber} в степени {secondNumber} равно {result}");
// }