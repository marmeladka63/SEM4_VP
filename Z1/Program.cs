// Разделение массива вывода массива пробел, запятая и т.д

using System;
Console.Clear();

int[] r= new int[5];


for (int i=0; i<5; i++)
{
    r[i]=new Random().Next(10);

}
Console.WriteLine(String.Join(", ",r.ToArray()));
