Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine());

Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($" --> ({x} , {y})");