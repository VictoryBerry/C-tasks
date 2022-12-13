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

int[] array = GetArray(123, 0, 200);
PrintArray(array);
Console.WriteLine();
int count = 0;

foreach (int el in array)
{
    if (el > 10 && el < 99) count++;
}
Console.WriteLine($" Количество элементов значений от 10 до 99 --> {count}");