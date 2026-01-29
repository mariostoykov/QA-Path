using System.ComponentModel.Design;

string product = Console.ReadLine();
string day  = Console.ReadLine();

if (product == "Banana")
{
    if (day == "Weekday")
    {
       Console.WriteLine($"{2.50:F2}");
    }
    else
    {
        Console.WriteLine($"{2.70:F2}");
    }
}
else if (product == "Apple")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{1.30:F2}");
    }
    else
    {
        Console.WriteLine($"{1.60:F2}");
    }

}
else if (product == "Kiwi")
{
    if (day == "Weekday")
    {
        Console.WriteLine($"{2.20:F2}");
    }
    else
    {
        Console.WriteLine($"{3.00:F2}");
    }

}