decimal usd = decimal.Parse(Console.ReadLine());
decimal usdEuroRate = 0.88m;
decimal euro = usd * usdEuroRate;

Console.WriteLine($"{euro:F2}");
