
int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

static void PrintRow1(int row)

{
    for (int col = 1; col <= row; col++)
    {
        Console.Write($"{col} ");
    }

    Console.WriteLine();
}

static void PrintRow2(int row)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write($"{col} ");
    }

    Console.WriteLine();
}

static void PrintTriangleUpperPart(int n)
{
    for (int row = 1; row <= n; row++)
    {
        PrintRow1(row);
    }
}

static void PrintTriangleLowerPart(int n)
{
    for (int row = n; row >= 1; row--)
    {
        PrintRow2(row);
    }
}

static void PrintTriangle(int n)
{
    PrintTriangleUpperPart(n - 1);

    PrintTriangleLowerPart(n);
}