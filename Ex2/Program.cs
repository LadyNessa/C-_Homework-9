Console.WriteLine("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int x, int y)
{
    if (x == y)
    {
        return y;
    }
    if (x > y)
    {
        return y + SumNumbers(x, y + 1);
    }
    else
    {
        return y + SumNumbers(x, y - 1);
    }
}

Console.Write("Сумма натуральных элементов в промежутке от M до N равна: ");
Console.WriteLine(SumNumbers(N, M));

