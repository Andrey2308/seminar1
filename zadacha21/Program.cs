//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите число х1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число х2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число z2: ");
double z2 = double.Parse(Console.ReadLine());
double dist = Math.Sqrt (Math.Pow (x2-x1, 2) + Math.Pow (y2-y1, 2) + Math.Pow (z2-z1, 2));
Console.WriteLine(dist);