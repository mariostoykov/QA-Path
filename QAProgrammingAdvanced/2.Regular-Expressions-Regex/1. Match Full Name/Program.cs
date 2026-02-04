using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);
MatchCollection validNames = regex.Matches(input);

foreach (Match name in validNames)
{
    Console.Write($"{name.Value} ");
}

Console.WriteLine();