Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int ElementSum = 0;

if (a / 10 > 0)
{
    while (a / 10 >= 1)
    {
        int n1 = a % 10;
        ElementSum = ElementSum + n1;
        a = a / 10;
    }
}
int result = ElementSum + a % 10;
Console.WriteLine("Сумма цифр, составляющих число равна " + result);


