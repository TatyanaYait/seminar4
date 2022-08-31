int Factorial(int a)
{
    int f = 1;
    for(int i = 1; i <= a; i++)
    {
         f = f * i;
        }
   return f;
}


Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
 while (b <= 1 )
    {
        Console.WriteLine("Введите число больше единицы ");
        b = int.Parse(Console.ReadLine());
    }
Factorial(b);
Console.WriteLine("факториал числа равен " + Factorial(b));