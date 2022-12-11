Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());


Console.WriteLine($" = {Product(N)}");
int Product(int number)
{
    int product = 1;
    while (number > 0)
    {
        Console.Write($"{number} * ");
        product = product * number;
        number--;


    }
    return product;
}