// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double Distance(int x1Coord, int y1Coord, int x2Coord, int y2Coord, int z1Coord, int z2Coord)
{ 
    double root = Math.Sqrt((x2Coord - x1Coord)*(x2Coord - x1Coord) + (y2Coord - y1Coord) * (y2Coord - y1Coord) + (z2Coord - z1Coord) * (z2Coord - z1Coord));
    double rootShort = Math.Round(root, 2, MidpointRounding.ToZero);
    return rootShort;
}

Console.WriteLine("Вводим координаты точки A: ");
int x1 = Prompt("Введите х1 = ");
int y1 = Prompt("Введите y1 = ");
int z1 = Prompt("Введите z1 = ");
Console.WriteLine("Вводим координаты точки B: ");
int x2 = Prompt("Введите х2 = ");
int y2 = Prompt("Введите y2 = ");
int z2 = Prompt("Введите z2 = ");
double result = Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Расстояние между точкой A({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) = {result} ");