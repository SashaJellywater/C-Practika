// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum=sum+i;
    }
    return sum;
}
int number = Prompt("Введите целое положительное число ");
int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");