// Ввести число а с консоли и получить сумму чисел от 1 до a

using System;
Console.Clear();

Console.Write("Введите число А:");
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));

int Summa( int number)
{
    int sum=0;
    for (int i=0; i<=number; i++)
    {
        sum+=i;
    }
    return sum;

}