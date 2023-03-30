// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// метод 
string Spreadsheet(int nNum)
{
    string spreadsheetResult = "________\n";
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"|{i}  | {i * i}| \n";
    }
    spreadsheetResult = spreadsheetResult+ "-----------";
    return spreadsheetResult;
}

Console.Write("Введи  число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result);

//   кому  Все
// int GetUserData()
// {
//     int newNumber = Convert.ToInt32(Console.ReadLine());

//     while (newNumber <= 0)
//     {
//         Console.WriteLine("Введите число больше 0");
//         newNumber = Convert.ToInt32(Console.ReadLine());
//     }
//     return newNumber;
// }

// void Square(int userNumber)
// {
//     for (int i = 1; i <= userNumber; i++)
//     {
//         Console.WriteLine($"|{i,3} | {i * i,3}|");
//     }
// }

// Square(GetUserData());
// int GetUserData()
// {
//     int newNumber;
//     Console.WriteLine("Сколько чисел возвести в квадрат");

//     while (!int.TryParse(Console.ReadLine(), out newNumber) && newNumber <= 0)
//     {
//         if (newNumber <= 0)
//         {
//             Console.WriteLine("Введите число больше 0");
//         }
//         else
//         {
//             Console.WriteLine(newNumber);
//             return newNumber;
//         }
//     }
    
//     return newNumber;
// }

// void Square(int userNumber)
// {
//     for (int i = 1; i <= userNumber; i++)
//     {
//         Console.WriteLine($"|{i,3} | {i * i,3}|");
//     }
// }

// Square(GetUserData());