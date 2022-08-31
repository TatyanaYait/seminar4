
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int stepen = 1;
for( int i = 1; i<= b; i++ )
{
    stepen = stepen *a;
}
Console.WriteLine();
Console.WriteLine(a + "^" + b + " = " + stepen);