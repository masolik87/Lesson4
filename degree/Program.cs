/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
*/

Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в которую нужно возвести число: ");
double b = Convert.ToInt32(Console.ReadLine());
double sum = a;
for (int i = 1; i < b; i++)
{ 
   sum *= a; // или sum = Math.Pow(a, b);
}   
Console.WriteLine(sum);
