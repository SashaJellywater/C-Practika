// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int numberRandom = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom}");


// int firstDigit = numberRandom / 10;
// int secondDigit = numberRandom % 10;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");
// // Math.Max(firstDigit, secondDigit)


// с помощью функции:
int maxDigit = MaxDigit(numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int numRandom) // numRandom = numberRandom
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;

}
