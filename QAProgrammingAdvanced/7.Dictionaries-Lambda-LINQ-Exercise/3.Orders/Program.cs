
Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
Dictionary<string, int> quantities = new Dictionary<string, int>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "buy")
        break;

    string[] parts = input.Split(' ');
    string name = parts[0];
    decimal price = decimal.Parse(parts[1]);
    int quantity = int.Parse(parts[2]);

    if (!prices.ContainsKey(name))
    {
        prices[name] = price;
        quantities[name] = quantity;
    }
    else
    {
        prices[name] = price;
        quantities[name] += quantity;
    }
}

    foreach (var product in prices)
    {
        string name = product.Key;
        decimal total = product.Value * quantities[name];

        Console.WriteLine($"{name} -> {total:F2}");
    }
