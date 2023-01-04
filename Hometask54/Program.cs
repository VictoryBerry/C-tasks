// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

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



void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)

    {
        for (int j = 0; j < inArray.GetLength(1); j++)

        {
            int max = j;
            for (int m = j + 1; m < inArray.GetLength(1); m++)
            {

                if (inArray[i, m] > inArray[i, max]) max = m;
            }
            int temp = inArray[i, j];
            inArray[i, j] = inArray[i, max];
            inArray[i, max] = temp;


            //Console.Write($"{inArray[i, j]} ");
        }
        // Console.WriteLine();
    }
}





Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);

PrintArray(array);


