//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = 1000;
int n = 1;
if (a < 100)
{
    Console.WriteLine("В числе " + a + " нет третьей цифры");
}
else
{
    while(a > i)
    {
        i = i*10;
        n = n*10;
    }
Console.WriteLine((a/n)%10 + " третья цифра числа");
}