// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

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


// void FindEl(int[,] array)
// {
//     Console.Write("Введите значение элемента массива N: ");
//     int N = int.Parse(Console.ReadLine());
//     int count = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (N == array[i, j])
//             {
//                 count++;
//             }

//         }
//         Console.WriteLine();
//     }
//     Console.Write($"Элемент {N} встречается {count} раз");
// }

void FindEl(int[,] array)
{

    int N = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (N == array[i, j])
            {
                count++;

            }
            else
            {
                Console.WriteLine($"Элемент {N} встречается {count} раз ");
                count = 0;
                N++;

            }

        }
        Console.WriteLine();

    }

    //Console.Write($"Элемент {N} встречается {count} раз ");
    //N++;
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();
FindEl(array);
