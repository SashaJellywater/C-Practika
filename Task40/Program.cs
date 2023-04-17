// Напишите программу, которая принимает на вход 3 числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух сторон.
int Prompt(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
bool IsTriangleReal(int a, int b, int c)
{
    return a + b < c || a + c < b || b + c < a;
}
int firstSide = Prompt("Введите длину первой стороны - ");
int secondSide = Prompt("Введите длину второй стороны - ");
int thirdSide = Prompt("Введите длину третьей стороны - ");
bool result = IsTriangleReal(firstSide, secondSide, thirdSide);
Console.WriteLine(result ? "Такой треугольник существовать не может." : "Такой треугольник может существовать.");