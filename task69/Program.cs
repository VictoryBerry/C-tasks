﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

int GetGrade(int a, int b)
{
    if (b == 0) return 1;
    else return a * GetGrade(a, b - 1);
}
Console.WriteLine(GetGrade(N, M));