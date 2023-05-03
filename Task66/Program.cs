// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM + SumNaturalNumbers(numM + 1, numN);
}

int firstNumber = Prompt("Введите целое число n = ");
int secondNumber = Prompt("Введите целое число m = ");
int result = 0;
if (firstNumber < 1 || secondNumber < 1) Console.WriteLine("Некорректный ввод");
else
{
    if (firstNumber < secondNumber) result = SumNaturalNumbers(firstNumber, secondNumber);
    else result = SumNaturalNumbers(secondNumber, firstNumber);
    Console.WriteLine(result);
}