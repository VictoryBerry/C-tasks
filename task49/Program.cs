

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

void ChangeArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) newArray[i, j] = array[i, j] * array[i, j];

            else newArray[i, j] = array[i, j];
            Console.Write($"{newArray[i, j]}  ");
        }
        Console.WriteLine();
    }


}




Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);

