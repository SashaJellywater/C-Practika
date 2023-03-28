//программа определяет день недели по введенному числу
Console.WriteLine("введите число");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Понедельник...ненавижу понедельники");
}
else if (day == "2")
{
    Console.WriteLine("Сегодня вторник");
}
else if (day =="3")
{
    Console.WriteLine("Середина рабочей недели - среда!");
}
else if (day == "4")
{
    Console.WriteLine("Четверг. Осталось чуть-чуть");
}
else if (day == "5")
{
    Console.WriteLine("Урра!!! Пятница!");
}
else if (day == "6")
{
    Console.WriteLine("Суббота - сегодня гуляем!");
}
else if (day == "7")
{
    Console.WriteLine("Уже воскресенье?! Завтра на работу");
}
else
{
    Console.WriteLine("Упс! Такого дня недели нет");
}