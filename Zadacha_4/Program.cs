// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;

Console.Write("Введите число a ");
int.TryParse(Console.ReadLine(), out int a);

Console.Write("Введите число b ");
int.TryParse(Console.ReadLine(), out int b);

Console.Write("Введите число c ");
int.TryParse(Console.ReadLine(), out int c);

    if (a > max)
    max = a;

    if (b > max)
    max = b;

    if (c > max)
    max = c;

{
Console.Write("Максимальное число = " + max);
}