Console.WriteLine("Задайте значение неотрицательного числа m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение неотрицательного числа n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else
    {
        if (y == 0)
        {
            return Akkerman(x-1, 1);
        }
        else
        {
            return Akkerman(x -1, Akkerman(x, y - 1));
        }
    }
}

Console.Write("Результат вычисления функции Аккермана равен: ");
Console.WriteLine(Akkerman(m, n));
