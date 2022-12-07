Console.Write("Введите номер четверти Q : ");
int Q = int.Parse(Console.ReadLine());

if (Q == 1)
{
    Console.WriteLine("X > 0 , Y > 0");
}

if (Q == 2)
{
    Console.WriteLine("X < 0 , Y > 0");
}

if (Q == 3)
{
    Console.WriteLine("X < 0 , Y < 0");
}

if (Q == 4)
{
    Console.WriteLine("X > 0 , Y < 0");
}