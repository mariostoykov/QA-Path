
string[] words = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> counts = new Dictionary<string,int>();
List<string> order = new List<string>();

foreach (string word in words)
{
    string wordLower = word.ToLower();

    if (!counts.ContainsKey(wordLower))
    {
        counts[wordLower] = 1;
        order.Add(wordLower);
    }
    else
    {
        counts[wordLower]++;
    }
}

foreach (string word in order)
{
    if (counts[word] % 2 != 0)
    {
        Console.Write(word + " ");
    }
}

Console.WriteLine();
