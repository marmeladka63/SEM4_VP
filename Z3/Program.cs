// ВВести число с консоли и посчитать количество цифр в нем
using System;
Console.Clear();

Console.Write("Введите число ");

int M = int.Parse(Console.ReadLine());


Console.WriteLine($"Количество цифр в числе: {count( M)}");


int count( int M)
{
    int i=0;
    
    while (M>0)
    {
      M/=10;
      i++;

    }
    return i;
}