//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number = 0;
while (number < 1 || number >=8)
{
    Console.WriteLine("Введите число от 1 до 7: ");
    number = int.Parse(Console.ReadLine());
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Невыходной день");
}