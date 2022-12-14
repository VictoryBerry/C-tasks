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

int[] array = GetArray(10, 100, 1000);
PrintArray(array);
Console.WriteLine();

int count = 0;
foreach (int el in array)
{
    if (el % 2 == 0) count++;
}
Console.WriteLine($" Количество четных элементов в массиве --> {count}");