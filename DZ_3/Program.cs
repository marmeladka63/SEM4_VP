// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
Console.Clear();

int[] r= new int[8];

for (int i=0; i<8; i++)
{
    r[i]=new Random().Next(100);

}
Console.WriteLine(String.Join(",",r ));