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

int[] array = GetArray(5, 1, 100);
PrintArray(array);
Console.WriteLine();



void MaxEl(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];




    }
    int diff = max - min;

    Console.Write($"Максимальное значение массива {max} , минимальное значение массива {min}  разница {diff}");

}

MaxEl(array);


