Console.Write ("Введите цифру, обозначающую день недели a = ");
int a = int.Parse(Console.ReadLine());

if (a == 6 || a == 7)
{
    Console.WriteLine("Да, это выходной день");
}

else
{
    Console.WriteLine("нет, это не выходной");
}
