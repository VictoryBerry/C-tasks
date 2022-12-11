int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);