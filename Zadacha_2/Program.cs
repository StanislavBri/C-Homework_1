﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

int max = 0;
int min = 0;

Console.WriteLine("Введите число a");
int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите число b");
int.TryParse(Console.ReadLine(), out int b);
    
if (a > b)
{
    max = a;
    min = b;
}
else
    max = b;
    min = a;
{
Console.Write("Максимальное число = " + max + " и " + "Минимальное число = " + min);
}
 