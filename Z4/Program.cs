// // Ввести число а с консоли и получить произведение чисел от 1 до a
using System;
Console.Clear();

Console.Write("Введите число А:");
Console.WriteLine(Product(int.Parse(Console.ReadLine())));

int Product( int number)
{
    int pro=1;
    for (int i=0; i<=number; i++)
    {
        pro*=i;
    }
    return pro;
}