Console.Write ("Введите число num = ");
int num = int.Parse(Console.ReadLine());
int num2 = num;
int count = 0;

while (num2 > 0)
{
    num2 /= 10; 
    count ++;
}
 if(count - 3 >= 0)
 {
   while (count - 3 > 0 ) 
   {
    num = num / 10;
    count --;
   }
   Console.WriteLine($"Третья цифра числа --> {num % 10}");

 }

 else 
 {
    Console.WriteLine("Третьей цифры нет");
 }