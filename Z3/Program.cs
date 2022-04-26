// ВВести число с консоли и посчитать количество цифр в нем
using System;
Console.Clear();

Console.Write("Введите число ");

Console.WriteLine(kols(int.Parse(Console.ReadLine())));

if ( kols>0)
{
   int M=kols;
}
else 
{
    Console.WriteLine("Введите положительное число");
}

int M( int number)
{
    int kol=1;
    int b= M/10; 
    if ( b>0)
    {
      kol++;
      b=b/10;



    }
    return b;
}
