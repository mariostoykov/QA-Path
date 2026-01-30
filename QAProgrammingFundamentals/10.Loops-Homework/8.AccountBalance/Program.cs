
string input = Console.ReadLine();

double bankAccount = 0;

while (input != "End")
{
    double currentAmount = double.Parse(input);

    if (currentAmount >= 0)
    {
        Console.WriteLine($"Increase: {currentAmount:F2}");
        bankAccount += currentAmount;
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(currentAmount):F2}");
        bankAccount += currentAmount;
    }
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {bankAccount:F2}");