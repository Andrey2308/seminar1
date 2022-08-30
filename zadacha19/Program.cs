//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        string str = Console.ReadLine();
        while (str.Length < 5 || str.Length > 5)
        {
            Console.WriteLine("Введите пятизначное число");
            str = Console.ReadLine();
        }
        if (str[0] == str[4] && str[1] == str[3]) 
        {
            Console.WriteLine("Это число палиндром");
        }    
else
        {
            Console.WriteLine("Это число не палиндром");
        }
    }
}