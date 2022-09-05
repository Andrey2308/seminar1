// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int count = 0;
while (a != 0)
{
    int LastDig = a%10;
    count = count + LastDig;
    a = a/10;

}
Console.WriteLine("Сумма цифр равна " + count);