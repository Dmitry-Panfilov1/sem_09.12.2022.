int[] array = FillArray(array);
Console.WriteLine(array);

PrintArray(array);

int[] FillArray()
{
    int array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine();
}