// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите, какое количество чисел вам надо сравнить");
int QuantityOfNumbers = int.Parse(Console.ReadLine());
int i = 0;
int count = 0;
string b = "";
while (i < QuantityOfNumbers)
{
    Console.WriteLine("Введите число ");
    int a = int.Parse(Console.ReadLine());
    if (a > 0)
    {
        count = count + 1;        
    }
    i++;
    b = b  + " " + a + ",";
       
}
Console.Write(b); 
Console.Write("-> " + count);

