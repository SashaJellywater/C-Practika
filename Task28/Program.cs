// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int FactorialNumbers(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            product *= i;
        }
    }
    return product;
}

int number = Prompt("Введите целое положительное число ");
if (number > 0)
{
    int result = FactorialNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine($"Введено отрицательное число");
}