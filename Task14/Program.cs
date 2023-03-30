// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число, которое проверяем на кратность(делимое)");
int number = Convert.ToInt32(Console.ReadLine());
// int firstNumber = 7;
Console.WriteLine("Введите первое число - делитель");
int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = 23;
Console.WriteLine("Введите второе число - делитель");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = MultipleTwoNumbers(number, firstNumber, secondNumber);
//если результат функции правдив(?) \/  если нет(:)\/ 
Console.WriteLine(result ? "Число кратное" : "Число не кратное");

bool MultipleTwoNumbers(int num, int firstNum, int secondNum)
{
    return num % firstNum == 0 && num % secondNum == 0;
}