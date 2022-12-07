Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Четверть 1");
}

if (X < 0 && Y > 0)
{
    Console.WriteLine("Четверть 2");
}

if (X < 0 && Y < 0)
{
    Console.WriteLine("Четверть 3");
}

if (X > 0 && Y < 0)
{
    Console.WriteLine("Четверть 4");
}