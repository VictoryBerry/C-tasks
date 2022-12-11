
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");
int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        Console.Write($"{number} ");
        sum += number;
        number--;

    }
    return sum;
}