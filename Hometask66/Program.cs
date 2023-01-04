// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

int LineNumbers(int N, int M)
{
    if (M == N) return N;


    else return N + LineNumbers(N - 1, M);


}

Console.WriteLine(LineNumbers(N, M));