
int[] numbersArrays = Console.ReadLine().
                        Split(" ").
                        Select(int.Parse).
                        ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstElement = numbersArrays[0];

    for (int j = 1; j < numbersArrays.Length; j++)
    {
        numbersArrays[j - 1] = numbersArrays[j];
    }

    numbersArrays[numbersArrays.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", numbersArrays));

