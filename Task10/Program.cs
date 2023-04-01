// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//                              *** Моё решение ***

// int SecondDigit(int num)
// {
//     int noHundreds = num % 100;
//     int noDozens = num % 10;
//     int sec = (noHundreds - noDozens) / 10;
//     return sec;
// }

// Console.WriteLine("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int secDigit = SecondDigit(number);
//     Console.WriteLine($"Вторая цифра числа: {secDigit}");
// }
// else
// {
//     Console.WriteLine($"Число {number} не трёхзначное");
// }

//                       ***Эталонное решение***
//метод ввода числа
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >999)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return; 
}
 Console.WriteLine($"Введенное число {number}");
int secondRank = number/10 %10;
  Console.WriteLine($"Вторая цифра {secondRank}");