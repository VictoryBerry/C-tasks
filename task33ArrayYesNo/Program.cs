int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 0;

foreach (int el in array)
{

    if (el == a)
    {
        count++;
    }



}
if (count > 0)
{
    Console.Write($"Число {a} --> yes ");
}
else
{
    Console.Write($"Число {a} --> no ");
}
