Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Количество цифр в числе {num} --> {NumsAmount(num)}");
Console.WriteLine($"Количество цифр в числе {num} --> {GetCount(num)}");
int NumsAmount(int number)
{
    int count = 1;
    while (number / 10 > 0)
    {

        count++;
        number = number / 10;

    }
    return count;
}
//либо 

int GetCount(int number)
{
    int count = 0;
    while (number > 0)
    {


        number = number / 10;
        count++;

    }
    return count;
}