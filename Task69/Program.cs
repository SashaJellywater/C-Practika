// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string message)
{
    Console.WriteLine(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int RaiseToDegree(int num, int numDegree)
 {
    //  if (numDegree == 0) return 1;
    //  if (num==0)return 0;
    //  else return num*RaiseToDegree(num,numDegree-1);
    return(numDegree == 0)? 1:num*RaiseToDegree(num,numDegree-1);
 }
int number = Prompt("Введите положительное целое число");
int degree = Prompt("Введите положительное целое число - степень");
if (degree<0)
Console.WriteLine("Некорректный ввод");
else
Console.WriteLine(RaiseToDegree(number, degree));