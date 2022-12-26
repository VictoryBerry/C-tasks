// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
    //int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lastPosition = array.GetLength(0) - 1;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[lastPosition, j];
            array[lastPosition, j] = temp;
        }
        break;
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
PrintArray(array);
