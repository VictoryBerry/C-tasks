Console.Write ("Введите трехзначное число a = ");
int num = int.Parse(Console.ReadLine());

int a2 = num / 10;
int result = a2 % 10;

Console.WriteLine($"число {num}  --> {result}");