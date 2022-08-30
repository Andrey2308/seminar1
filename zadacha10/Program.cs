//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = 99;

while (number < 100 || number >=1000)
{
    Console.WriteLine("Введите трехзначное число: ");
    number = int.Parse(Console.ReadLine());
}
int a = number / 10;
int b = number / 100;
Console.WriteLine("Вторая цифра в этом числе это " + (a - b*10));