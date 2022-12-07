Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int a = 1;

Console.Write($" {N} -->");
while (a <= N)
{
    int result = a * a;
    Console.Write($" {result}");
    a++;


}
