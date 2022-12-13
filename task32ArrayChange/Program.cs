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

int[] ChangeArray(int[] array)
{

    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

PrintArray(ChangeArray(array));

