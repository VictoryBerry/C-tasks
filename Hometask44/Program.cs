// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int[] CreateArray()
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Введите {i} элемент массива:");
        array[i] = int.Parse(Console.ReadLine());

    }
    Console.WriteLine(string.Join(" ", array));
    return array;
}

int[] array = CreateArray();



// void CountPositive(int[] inArray)
// {
//     int count = 0;
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         if (inArray[i] > 0)
//         {
//             count++;

//         }


//     }
//     Console.Write($" положительных чисел --> {count}");
// }

// CountPositive(array);


int count = 0;

foreach (int el in array)
{
    if (el > 0) count++;

}
Console.Write($" положительных чисел --> {count}");
