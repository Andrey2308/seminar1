//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число n");
double n = double.Parse(Console.ReadLine());
Console.Write(n + " ->");
n = Math.Abs(n);
for (int i = 1; i<=n; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}