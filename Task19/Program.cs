// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Функция повторного ввода чисел:
int Prompt(string message)
{
    Console.WriteLine(message);
    int newNum = Convert.ToInt32(Console.ReadLine());
    if (newNum<0)
    {
        newNum= -newNum;
    }
    while (newNum>100000 || newNum<9999 && newNum>1)
    {
        Console.WriteLine("Неправильно! Введите пятизначное число");
        newNum = Convert.ToInt32(Console.ReadLine());
    }
    return newNum;
}
//Функция проверки на палендром и вывода результата:
bool IsNumberPaliandrom(int number)
{
   if((number %100000-number%10000)/10000 == (number%10) && (number %10000-number%1000)/1000 == (number%100-number%10)/10)
   {
    Console.WriteLine($"Число {number} - палиндром");
    return true;
   }
   Console.WriteLine($"Число {number} -  не палиндром");
   return false;
}

int fiveDigitNumber = Prompt("Введите пятизначное число");
bool paliandrom = IsNumberPaliandrom(fiveDigitNumber);