//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;
Console.Clear();

Console.Write("Введите число А:");


Console.WriteLine(summa(int.Parse(Console.ReadLine())));


int summa( int M)
{
   int sum=0;

    for (int i=1; i<=A; i++)
    {
        sum=sum+A%10;
        A=A/10;

    }
    return A;
}

