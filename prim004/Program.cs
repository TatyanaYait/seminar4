void FillArray(int[] numbA)
{
    int length = numbA.Length;
    int index = 0;
    while (index < length)
    {
        numbA[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] numbB)
{
    int count = numbB.Length;
    int posit = 0;
    while (posit < count)
    {
        Console.Write(numbB[posit] + ", ");
        posit++;
    }
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();
Console.WriteLine();