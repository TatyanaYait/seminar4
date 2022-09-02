Console.Write("Введите желаемый размер массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine());

int[] array = new int [n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max+1);
}
Console.WriteLine();
Console.WriteLine(string.Join(",", array));
Console.WriteLine();

 
