/*void SumNumbers(int n) {  // функция, позволяющая работать толлько с консолью
    int sum = 0;
    for (int i = 1; i <= n; i++)    {
        sum = sum + i;  //  sum += i;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

SumNumbers(a);   // вызов функции с аргументом, введенным с клавиатуры*/


// математическая формула SUM = N * (N + 1) / 2;

int SumNumbers(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum = sum + i;  //  sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

SumNumbers(a);   // int result = SumNumbers(a);
Console.WriteLine(SumNumbers(a)); // или задать переменную, в которую записать результат 
