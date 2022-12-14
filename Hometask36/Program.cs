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

int[] array = GetArray(10, 1, 100);
PrintArray(array);
Console.WriteLine();

// int OddElSum(int[] array)
// {
//     int count = 0;
//     for (int i = 1; i < array.Length; i = i + 2) count = count + array[i];
//     return count;
// }

// Console.Write(OddElSum);

void OddElSum(int[] array)
{
    int i = 1;

    int oddElSum = 0;
    while (i < array.Length)
    {
        oddElSum = oddElSum + array[i];
        i = i + 2;

    }

    Console.Write($"Сумма элементов на нечетных позициях --> {oddElSum} ");

}
OddElSum(array);


