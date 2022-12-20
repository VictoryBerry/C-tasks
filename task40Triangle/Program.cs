Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

TrianglePoss(a, b, c);

void TrianglePoss(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.Write($"Triangle possible");

    }
    else
    {
        Console.Write($"Triangle not possible");
    }

}

