// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
using System;
Console.Clear();

Console.Write("Введите число A=");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень B=");
double B = Convert.ToDouble(Console.ReadLine());


double L= (Math.Pow(A,B));

Console.WriteLine($"Ответ {L}");