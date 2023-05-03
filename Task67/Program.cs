// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    Console.WriteLine(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int DigitNumber(int num)
 {
    //  if (num == 0) return 0;
    //  else return num %10+SumDigitNumber(num/10);
    return (num==0)? 0: num %10+DigitNumber(num/10);
 }
int number = Prompt("Введите положительное целое число ");
int result = DigitNumber(number);
Console.WriteLine(result);
