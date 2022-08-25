//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число");
double a = double.Parse(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine("Введено четное число");
}
else 
{
    Console.WriteLine("Введено нечетное число");
}