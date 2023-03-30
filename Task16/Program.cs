// 16 Напишите программу, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = 23;
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool square = IsNumbersSquare(firstNumber, secondNumber);
Console.WriteLine(square? "Одно из чисел является квадратом другого": "Ни одно из чисел не является квадратом другого");

bool IsNumbersSquare(int firstNum, int secondNum)
{
    return firstNumber == secondNum*secondNum || secondNum == firstNum*firstNum;
}