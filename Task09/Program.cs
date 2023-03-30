// Напишите программуБ которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int numberRandom = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom}");


int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");

}
else
{
    Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");

}

// Math.Max(firstDigit, secondDigit)