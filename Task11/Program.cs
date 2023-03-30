// // Напашите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// int numberRandom = new Random().Next(100, 1000); 

// Console.WriteLine($"Случайное трёхзначное число => {numberRandom}");
// int firstDigit= numberRandom /100 ;
// int secondDigit = numberRandom % 10;
// int findNumber = firstDigit*10 +secondDigit;
// Console.WriteLine($"Искомое число => {findNumber}");

int numberRandom = new Random().Next(100, 1000); 
int newNumber = DeleteSecondDigit(numberRandom);
Console.WriteLine($"Случайное трёхзначное число => {numberRandom}");
Console.WriteLine($"Полученное двухзначное число => {newNumber}");
int DeleteSecondDigit(int numRandom)
{
int firstDigit= numberRandom /100 ;
int secondDigit = numberRandom % 10;
int findNumber = firstDigit*10 +secondDigit;
return findNumber;
}