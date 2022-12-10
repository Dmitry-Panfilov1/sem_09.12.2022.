Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int count = Counter(number);
Console.WriteLine(count);

int Counter(int a)
{
    int count = 1;
    while (a > 9)
    {
        a = a/10;
        count++;
    }
    return count;
}
