
char starLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

int counter = 0;

for (int i = starLetter; i <= endLetter; i++)
{
    if (i == excludedLetter)
        continue;

    for (int j = starLetter; j <= endLetter; j++)
    {
        if (j == excludedLetter)
            continue;

        for (int k = starLetter; k <= endLetter; k++)
        {
            if (k == excludedLetter)
                continue;
            

            Console.Write($"{(char)i}{(char)j}{(char)k} ");
            counter++;
        }
    }
}
Console.WriteLine();
Console.WriteLine(counter);