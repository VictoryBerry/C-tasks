
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindEl(int[,] array)
{
    Console.Write("Введите индекс строки row: ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Введите индекс столбца column: ");
    int colum = int.Parse(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row == i && colum == j) Console.Write($"[{row},{colum}] --> {array[i, j]} ");
            else Console.WriteLine("такого элемента нет");


        }
        Console.WriteLine();
    }



}







// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
FindEl(array);