// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)


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

//else Console.WriteLine("такого элемента нет");
//Console.Write($"[{row},{colum}] --> {array[i, j]} ");




// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
FindEl(array);