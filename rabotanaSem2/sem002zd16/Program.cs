﻿// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == a*a)
{
    System.Console.WriteLine($"да, число {b} является квадратом числа {a}");
    }

    else {System.Console.WriteLine("нет");}