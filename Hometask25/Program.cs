Console.Write("Введите число A = ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B = ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($" {A} в степени {B} = {Power(A, B)}");


int Power(int number, int power)
{
    int result = 1;

    while (power > 0)
    {
        result *= number;
        power--;
    }
    return result;


}