//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе с применением метода

using System;
Console.Clear();

Console.Write("Введите число А:");
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));

int Summa( int A)
{
    
   int sum=0;

    for (int i=1; i<=A; i++)
    {
        sum=sum+A%10;
        A=A/10;
    }
      return sum;
}
