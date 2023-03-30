// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// если число 1 не кратно числу 2, то программа выводит остаток от деления.
Console.WriteLine("введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Multiple(firstNumber, secondNumber);
WriteResult(result);

int Multiple(int num1, int num2)
{
    return num1 % num2;
}
void WriteResult(int multiple)
{
    if (multiple == 0)
    {
        Console.WriteLine($"кратно");
    }
    else
    {
        Console.WriteLine($"не кратно, остаток = > {multiple}");
    }
}
