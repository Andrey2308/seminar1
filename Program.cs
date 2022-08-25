//Напишите программу, которая на вход принимает два числа, и выдает какое меньшее, а какое большее
Console.WriteLine("Введите число 1"); 
int num1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2"); 
int num2 =int.Parse(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine("Первое число больше второго"); 
}
else if(num1<num2)
{
    Console.WriteLine("Первое число меньше второго");
} 
else
{
    Console.WriteLine("Оба числа равны"); 
}