Console.WriteLine("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetNumbers(int x)
{
    Console.WriteLine(x);
    if (x == 1)
    {
        return 1;
    }
    else
    {
        return x - GetNumbers(x-1);

    }
}

GetNumbers(N);