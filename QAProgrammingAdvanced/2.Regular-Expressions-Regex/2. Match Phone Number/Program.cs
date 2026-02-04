
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

foreach (Match number in matches)
{
    Console.WriteLine(number.Value + " ");
}

