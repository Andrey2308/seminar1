// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while(index<length)
    {
        coll[index] = new Random().Next(0,100);
        index++;
    }
}
void PrintArray(int [] coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }
    Console.Write("]");
}
int [] array = new int[8];
FillArray (array);
PrintArray (array);

