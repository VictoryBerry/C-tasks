// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());


int SumNum(int a)
{

    if (a > 0) a = a % 10 + SumNum(a / 10);

    return (a);

}
Console.Write(SumNum(N));