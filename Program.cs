﻿Console.Clear();
Console.Write("Веедите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
Console.WriteLine($"{i} -> {i * i * i}");