﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите любое число!");
string? aa = Console.ReadLine();
int a = Convert.ToInt32(aa);

for (int i = 1; i <= a; i++)
{
    Console.WriteLine("Таблица кубов чисел от 1 до " + aa + ", при " +i+ ": " + (Math.Pow(i, 3)));
}