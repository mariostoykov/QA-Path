
int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!words.ContainsKey(word))
    {
        words.Add(word, new List<string>());
    }
    words[word].Add(synonym);
}

foreach (var entry in words)
{
    string word = entry.Key;
    List<string> synonyms = entry.Value;
    string synonymList = string.Join(", ", synonyms);

    Console.WriteLine($"{word} - {synonymList}");
}