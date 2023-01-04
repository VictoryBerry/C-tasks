// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

void LineNumbers(int N, int M)
{
    if (M > N) LineNumbers(N + 1, M);
    Console.Write($"{N} ");
    if (N > M) LineNumbers(N - 1, M);


}

LineNumbers(N, M);