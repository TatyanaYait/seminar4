int CountNumber(int n)
{
    int res = 0;
    n = Math.Abs(n);   ///взятие числа по модулю
    while ( n >= 0)
    {
        res ++;
        n = n/10;
    }
    return res;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int itog = CountNumber(a);
Console.WriteLine(itog);
