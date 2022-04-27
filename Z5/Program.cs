// Напишите программу,которая выводит массив из 8 элементов , заполненный нулями и еденицами в случайном порядке [0,1,0,1,0,0,1,1]
using System;
Console.Clear();

int[] r= new int[8];

for (int i=0; i<8; i++)
{
    r[i]=new Random().Next(2);

}
Console.WriteLine(String.Join(", ",r));
