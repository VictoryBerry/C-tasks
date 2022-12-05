Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("да одно число является квадратом другого");

}

else if (b == a*a)
{
    Console.WriteLine("да одно число является квадратом другого");
}

else
{
    Console.WriteLine("нет одно число не является квадратом другого");
}
