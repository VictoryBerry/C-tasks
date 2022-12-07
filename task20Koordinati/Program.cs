Console.Write("Введите координаты точки A: x1 ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки A: y1 ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B: x2 ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B: y2 ");
int y2 = int.Parse(Console.ReadLine());



double Length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.Write($" расстояние между координатами {Length}");