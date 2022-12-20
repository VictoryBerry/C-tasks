// void ChangeToDouble(int i)
// {
//     int res = i % 2;
//     while (i > 0)
//     {
//         if (res == 0)
//         {
//             Console.WriteLine("0");
//             i = i / 2;

//         }
//         else
//         {
//             Console.WriteLine("1");
//             i = i / 2;

//         }

//     }
// }

Console.Write("Введите число i: ");
int i = int.Parse(Console.ReadLine());


// string numDouble = " ";


// while (i > 0)

// {
//     int res = i % 2;
//     numDouble = res + numDouble;
//     i = i / 2;


// }
// Console.Write(numDouble);

void ChangeToDouble(int i)
{
    string numDouble = " ";
    while (i > 0)

    {
        int res = i % 2;
        numDouble = res + numDouble;
        i = i / 2;


    }
    Console.Write(numDouble);

}





ChangeToDouble(i);

