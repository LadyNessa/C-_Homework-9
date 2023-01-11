void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
     { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] +  " ");
            }
            else
            {
                Console.Write(array[i, j] +  " ");
            }
        }
        Console.WriteLine();
    }
}

int [,] arr = new int[4,4];

int x = 1;
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = x;
        x++;
    }
}

x = 5;
for (int i = 1; i < arr.GetLength(0); i++)
{
    for (int j = 3; j < arr.GetLength(1); j++)
    {
        arr[i,j] = x;
        x++;
    }
}

x = 10;
for (int i = 3; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = x;
        x--;
    }
}

x = 12;
for (int i = 1; i < 3; i++)
{
    for (int j = 0; j < 1; j++)
    {
        arr[i,j] = x;
        x--;
    }
}

x = 13;
for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < 3; j++)
    {
        arr[i,j] = x;
        x++;
    }
}

x = 16;
for (int i = 2; i < 3; i++)
{
    for (int j = 1; j < 3; j++)
    {
        arr[i,j] = x;
        x--;
    }
}

PrintArray(arr);
