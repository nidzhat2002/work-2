﻿Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
if (n < 100)
    Console.WriteLine($"Третьей цифры у числа {n} нет.");
else 
{
    while (m > 999) m /= 10;
    Console.WriteLine($"Третья цифра у числа {n}: {m % 10}.");
}