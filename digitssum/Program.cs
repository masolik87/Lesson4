/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int b;
while (a !=0)
{
    b = a%10;
    a = a/10;
    sum = sum + b;
}
Console.WriteLine(sum);