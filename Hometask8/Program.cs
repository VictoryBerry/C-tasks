Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());

int a = 1;

while (a < N+1)
{
    if (a%2 == 0)
    {
        Console.Write(a);
        a = a + 1;
    }
    else 
    {
        a = a + 1;
    }
    
}
