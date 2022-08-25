//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using System;

public class Program
{
public static void Main()
{
Console.WriteLine("Введите первое число");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число");
Console.WriteLine(max);
}
}