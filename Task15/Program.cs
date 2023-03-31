bool WhatDayIsIt(int num)
{
     return num < 6; 
}

Console.WriteLine("введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
bool result = WhatDayIsIt(day);

if (day<1 || day>7)
{
    Console.WriteLine("Нет такого дня недели. Введите число от 1 до 7");
}
else
    Console.WriteLine(result ? "Не выходной день." : "Сегодня выходной!");