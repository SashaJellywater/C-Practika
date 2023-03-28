//программа принимает число и выдаёт его квадрат
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square_number = number * number;
Console.WriteLine($"Квадрат числа {number} = {square_number}");