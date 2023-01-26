// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int.TryParse(Console.ReadLine(), out int N);

int chet = 2;
    if (N > chet)
    {
        while (chet <= N)
        {
        Console.Write(chet + " ");
        chet = chet + 2;
        }
    }
    else
    {
        Console.Write(N + " некорректное число");
    }
    

