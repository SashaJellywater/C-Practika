// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// метод 
string Spreadsheet(int nNum)
{
    string spreadsheetResult = "________\n";
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"|{i, 3}  | {i * i, 3}| \n";
    }
    spreadsheetResult = spreadsheetResult+ "-----------";
    return spreadsheetResult;
}

Console.Write("Введи  число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result);