// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int AckermanNumber(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    if (numM == 0) return AckermanNumber(numN - 1, 1);
    return AckermanNumber(numN - 1, AckermanNumber(numN, numM - 1));
}
int firstNumber = Prompt("Введите целое число m = ");
int secondNumber = Prompt("Введите целое число n = ");
if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine($"Введены некорректные значения");
}
else
{
    int result = AckermanNumber(firstNumber, secondNumber);
    Console.WriteLine($"Результат вычисления функции Аккермана A(m,n) = {result}");
}