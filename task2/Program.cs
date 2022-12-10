Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);

int prodGlobal = Productioner(N);
Console.WriteLine(prodGlobal);

int Productioner(int a)
{
    int production = 1;
    for (int i = 1; i <= a; i++)
    {
        production = production * i;
    }
    return production;
}
