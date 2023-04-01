// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// A1(x1, y1) && A2(x2, y2)   A1A2 = корень из ((x2-x1)квадрат + (y2-y1)квадрат)
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double Distance(int X1, int Y1, int X2, int Y2)
{
    //функция Math.Sqrt - извлекает корень)
    double root = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));
    double rootShort = Math.Round(root, 2, MidpointRounding.ToZero); 
    return rootShort;
}

Console.WriteLine("Вводим координаты первой точки: ");
int x1 = Prompt("Введите х1 = ");
int y1 = Prompt("Введите y1 = ");
Console.WriteLine("Вводим координаты второй точки: ");
int x2 = Prompt("Введите х2 = ");
int y2 = Prompt("Введите y2 = ");
double result = Distance(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точкой A({x1}, {y1}) и точкой B({x2}, {y2}) = {result} ");

// Андрей Булгаков 

// double Distance (int X1Coord, int Y1Coord, int X2Coord,int Y2Coord)
// {
//     return Math.Round(Math.Sqrt((X1Coord-X2Coord)*(X1Coord-X2Coord)+(Y1Coord-Y2Coord)*(Y1Coord-Y2Coord)),2, MidpointRounding.ToZero); 
// }

// Console.Write("Введи  X1:");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи  Y1:");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи  X2:");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи  Y2:");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double result = Distance(X1,Y1,X2,Y2);
// Console.Write(result);