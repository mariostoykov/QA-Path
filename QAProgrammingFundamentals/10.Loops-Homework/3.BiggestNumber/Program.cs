
int n = int.Parse(Console.ReadLine());

int biggestNum = int.MinValue;
for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum > biggestNum)
    {
        biggestNum = currentNum;
    }
}

Console.WriteLine(biggestNum);
