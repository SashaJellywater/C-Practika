// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int k1 = Prompt("Введите число - ");
int k2 = Prompt("Введите число - ");
int b1 = Prompt("Введите число - ");
int b2 = Prompt("Введите число - ");
double x = (b2 - b1)/ (k1 - k2);
double y = k1*x +b1;
y = k2*x +b2;
    if (((k1 == 0) && (b1 == 0)) || ((k2 == 0) && (b2 == 0)))
        Console.Write("Это не прямая.");
    else if (((k1 * b2) == (k2 * b1)))
        Console.Write ("Прямые совпадают.");
    else if ((k1 == b2) == (k2 == b1))
        Console.Write ("Прямые параллельны");
    else