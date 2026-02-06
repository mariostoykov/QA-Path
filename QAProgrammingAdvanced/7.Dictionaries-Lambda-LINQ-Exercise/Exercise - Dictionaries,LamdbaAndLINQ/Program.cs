
string input = Console.ReadLine();

Dictionary<char, int> counts = new Dictionary<char, int>();

foreach (char ch in input)
{
    if (ch == ' ')
        continue;

    if (!counts.ContainsKey(ch))
    {
        counts[ch] = 1;
    }
    else
    {
        counts[ch]++;
    }
}

foreach (var entry in counts)
{
    Console.WriteLine($"{entry.Key} -> {entry.Value}");
}