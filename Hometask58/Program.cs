// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MartixMult(int[,] inArray1, int[,] inArray2)
{
    int[,] newArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    if (inArray1.GetLength(1) != inArray2.GetLength(0))
    {
        Console.WriteLine(" Матрицы невозможно перемножить");
    }
    else
    {
        for (int i = 0; i < inArray1.GetLength(0); i++)
        {
            for (int j = 0; j < inArray2.GetLength(1); j++)
            {
                for (int l = 0; l < inArray2.GetLength(0); l++)
                {
                    newArray[i, j] = inArray1[i, l] * inArray2[l, j] + newArray[i, j];
                }
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums1 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, colums1, 0, 10);
PrintArray(array1);

Console.Write("Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums2 = int.Parse(Console.ReadLine());

int[,] array2 = GetArray(rows2, colums2, 0, 10);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
MartixMult(array1, array2);