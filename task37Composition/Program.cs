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

int[] array = GetArray(11, 0, 10);
PrintArray(array);
Console.WriteLine("-->");


int i = 0;
int n = array.Length - 1;
int Product;
while (i < array.Length / 2)
{
    Product = array[i] * array[n];
    i++;
    n--;
    Console.Write($" {Product} ");
}







