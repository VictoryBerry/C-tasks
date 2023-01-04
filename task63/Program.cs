// Рекурсия 
// вывести все натуральные числа от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void LineNumbers(int N)
{
    if (N != 1) LineNumbers(N - 1);
    Console.Write($" {N} ");
}

LineNumbers(N);