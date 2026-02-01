
int[] numbersArrays = Console.ReadLine().
                        Split(" ").
                        Select(int.Parse).
                        ToArray();

for (int i = 0; i < numbersArrays.Length - 1; i++)
{
    bool isGreater = true;
    int currentElement = numbersArrays[i];

    for (int j = i + 1 ; j < numbersArrays.Length; j++)
    {
        int nextRightElement = numbersArrays[j];

        if (currentElement <= nextRightElement)
        {
            isGreater = false;
            break;
        }
    }

    if (isGreater)
    {
        Console.Write(currentElement + " ");
    }
}

Console.Write(numbersArrays[numbersArrays.Length - 1]);