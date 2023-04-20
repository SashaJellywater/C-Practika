// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
double FirstCoordinateNumber(double lineK1, double lineB1, double lineK2, double lineB2)
{
    double xCoord = (lineB1 - lineB2) / (lineK2 - lineK1);
    return xCoord;
}
double SecondCoordinateNumber(double lineK1, double lineB1, double PointX)
{
    double yCoord = lineK1 * PointX + lineB1;
    return yCoord;
}
void DoubleCut(double num)
{
    Math.Round(num, 2, MidpointRounding.ToZero);
}
bool IsLineIntersect(double lineK1, double lineB1, double lineK2, double lineB2)
{
    if (lineK1 == lineK2 && lineB1 == lineB2)return false;
    else return true;
}
double lineNumberK1 = Prompt("Введите число k1 - ");
double lineNumberB1 = Prompt("Введите число b1 - ");
double lineNumberK2 = Prompt("Введите число k2 - ");
double lineNumberB2 = Prompt("Введите число b2 - ");
bool result = IsLineIntersect(
                                lineNumberK1,
                                lineNumberB1,
                                lineNumberK2,
                                lineNumberB2
                             );
double x = FirstCoordinateNumber(
                                 lineNumberK1,
                                 lineNumberB1,
                                 lineNumberK2,
                                 lineNumberB2
                                 );
double y = SecondCoordinateNumber(lineNumberK1, lineNumberB1, x);
DoubleCut(x);
DoubleCut(y);
Console.WriteLine(result?$"Координаты точки пересечения прямых - ({x}, {y})"
                        :"Нет точек пересечения:прямые параллельны или совпадают");