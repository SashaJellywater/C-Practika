// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//                              *** Моё решение ***
// //функция перехода в трехзначное число
// int ThreeDigitNumber(int numbers)
// {
// while (numbers>1000)
// {
//     numbers = numbers/10;
// }
// return numbers;
// }
// //вывода числа бул
// bool IsTherdDigit (int enterNumber)
// {
//     return enterNumber > 99;
// }

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >1000) num = ThreeDigitNumber(num);
// int find = num%10;
// bool result = IsTherdDigit(num);
// Console.WriteLine(result ? $"третья цифра числа {find}" : "Третьей цифры нет");

//                       ***Эталонное решение***
//метод ввода числа
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
//метод нахождения третьей цифры
int GetThirdRank(int number)
{
    while (number>999)
    {
        number/=10;
    }
    return number%10;
}
// метод результата
bool ValidateNumber(int number)
{
    if (number <100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}