Console.Write ("Введите число a = ");
int a = int.Parse(Console.ReadLine());

Console.Write ("Введите число b = ");
int b = int.Parse(Console.ReadLine());
int c = a / b;

if (a % b == 0)
{
    Console.WriteLine($"число {b} кратно числу {a}");
}

if (a % b != 0)
{
    Console.WriteLine($"число {b} некратно числу {a} остаток {c}");
}