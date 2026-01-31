
string type = Console.ReadLine();

if (type == "int")
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(GetMaxNumber(a, b));
}
else if (type == "char")
{
    char a = char.Parse(Console.ReadLine());
    char b = char.Parse(Console.ReadLine());
    Console.WriteLine(GetMaxChar(a, b));
}
else
{
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    Console.WriteLine(GetMaxString(a, b));
}

static string GetMaxString(string a, string b)
{
    int result = a.CompareTo(b);
    if (result > 0)
    {
        return a;
    }
    else
    {
        return b;
    }
}
static char GetMaxChar(char a, char b)
{
    char result = b;
    if (a > b)
    {
        result = a;
    }

    return result;
}
static int GetMaxNumber(int a, int b)
{
    int result = b;
    if (a > b)
    {
        result = a;
    }

    return result;
}
