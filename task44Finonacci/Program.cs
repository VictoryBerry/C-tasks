Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] listFib = new int[N];
listFib[0] = 0; Console.Write(listFib[0]);
listFib[1] = 1; Console.Write(listFib[1]);
for (int i = 2; i < N; i++)
{
    listFib[i] = listFib[i - 1] + listFib[i - 2];
    Console.Write(listFib[i]);

}

