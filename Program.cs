Console.WriteLine("ЭТО ПРОГРАММА КАЛЬКУЛЯТОР");
Console.WriteLine("Введите 1ое число");
int a =
    Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ое число");
int b =
    Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите операцию: ");
    int c =
    Convert.ToInt32(Console.ReadLine());
while (c != 9)
{
    if (c == 1)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(a + b);
    }
    if (c == 2)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(a - b);
    }
    if (c == 3)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(a * b);
    }
    if (c == 4)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(a / b);
    }
    if (c == 5)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(Math.Pow(a, b));
    }
    if (c == 6)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(Math.Sqrt(a));
        Console.WriteLine(Math.Sqrt(b));
    }
    if (c == 7)
    {
        Console.WriteLine("Результат: ");
        Console.WriteLine(a * 0.01);
        Console.WriteLine(b * 0.01);
    }
    if (c == 8)
    {
        int f = 1;
        for (int i = 1; i <= b; i++)
        {
            f = f * i;
        }
        Console.WriteLine("Результат: ");
        Console.WriteLine(f);
    }
    Console.WriteLine("Введите операцию: ");
    c =
        Convert.ToInt32(Console.ReadLine());
}