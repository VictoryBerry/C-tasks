Console.Write("Введите пятизначное число N: ");
int N = int.Parse(Console.ReadLine());


if (N / 10000 == N % 10 && (N / 1000) % 10 == (N / 10) % 10)
{
    Console.WriteLine($" число {N} является полиндромом");
}
else
{
    Console.WriteLine($"Число {N} не является полиндромом");
}