//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//                              *** Моё решение ***
// bool WhatDayIsIt(int num)
// {
//      return num < 6; 
// }

// Console.WriteLine("введите число от 1 до 7");
// int day = Convert.ToInt32(Console.ReadLine());
// bool result = WhatDayIsIt(day);

// if (day<1 || day>7)
// {
//     Console.WriteLine("Нет такого дня недели. Введите число от 1 до 7");
// }
// else
//     Console.WriteLine(result ? "Не выходной день." : "Сегодня выходной!");

//                       ***Эталонное решение***

//метод ввода числа
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

int weekDay = Prompt("Введите день недели > ");
if (ValidateWeekday(weekDay))
{
    if(IsWeekend(weekDay))
    {
        Console.WriteLine("Выходной");
    }
    else 
    {
        Console.WriteLine("не выходной");
    }
}